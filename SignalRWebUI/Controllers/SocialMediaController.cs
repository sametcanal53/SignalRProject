﻿using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.SocialMedias.Create;
using SignalRWebUI.Dtos.SocialMedias.Model;
using SignalRWebUI.Dtos.SocialMedias.Update;
using System.Net.Http;
using SignalRWebUI.Dtos.Contacts.Model;

namespace SignalRWebUI.Controllers
{
    public class SocialMediaController : GenericController<GetSocialMediaDto, CreateSocialMediaDto, UpdateSocialMediaDto>
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public SocialMediaController(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public override async Task<IActionResult> Create()
        {
            await GetSelectListItems();
            return View();
        }

        [HttpGet]
        public override async Task<IActionResult> Update(int id)
        {
            await GetSelectListItems();
            return base.Update(id).Result;
        }

        // Private Methods
        private async Task GetSelectListItems()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:5353/api/Contact");
            var content = await response.Content.ReadAsStringAsync();
            var contacts = JsonConvert.DeserializeObject<List<GetContactDto>>(content);
            List<SelectListItem> selectListItems = (from contact in contacts
                                                    select new SelectListItem
                                                    {
                                                        Text = contact.FooterTitle,
                                                        Value = contact.Id.ToString()
                                                    }).ToList();
            ViewBag.Contacts = selectListItems;
        }
    }
}

﻿using blazorPaginationLoadNext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorPaginationLoadNext.Services
{
    public class PostsService
    {
        private List<post> _posts=new List<post> { 
            new post { title="Снежный барс", content="Сделанные на базе интернет-аналитики выводы, превозмогая сложившуюся непростую экономическую ситуацию, указаны как претенденты на роль ключевых факторов. Имеется спорная точка зрения, гласящая примерно следующее: интерактивные прототипы и по сей день остаются уделом либералов, которые жаждут быть превращены в посмешище, хотя само их существование приносит несомненную пользу обществу. С другой стороны, постоянный количественный рост и сфера нашей активности выявляет срочную потребность соответствующих условий активизации.", cover_image="https://i.artfile.ru/2048x1365_909032_[www.ArtFile.ru].jpg"},
            new post { title="Снежный барс на природе", content="Сделанные на базе интернет-аналитики выводы, превозмогая сложившуюся непростую экономическую ситуацию, указаны как претенденты на роль ключевых факторов. Имеется спорная точка зрения, гласящая примерно следующее: интерактивные прототипы и по сей день остаются уделом либералов, которые жаждут быть превращены в посмешище, хотя само их существование приносит несомненную пользу обществу. С другой стороны, постоянный количественный рост и сфера нашей активности выявляет срочную потребность соответствующих условий активизации.", cover_image="https://volonter61.ru/800/600/https/fs3.fotoload.ru/f/0318/1521550896/cc8ff78895.jpg"},
            new post { title="Снежный барс вышел на прогулку", content="Сделанные на базе интернет-аналитики выводы, превозмогая сложившуюся непростую экономическую ситуацию, указаны как претенденты на роль ключевых факторов. Имеется спорная точка зрения, гласящая примерно следующее: интерактивные прототипы и по сей день остаются уделом либералов, которые жаждут быть превращены в посмешище, хотя само их существование приносит несомненную пользу обществу. С другой стороны, постоянный количественный рост и сфера нашей активности выявляет срочную потребность соответствующих условий активизации.", cover_image="https://proprikol.ru/wp-content/uploads/2020/12/snezhnye-barsy-krasivye-kartinki-38.jpg"},
            new post { title="Снежный барс на солнышке", content="Сделанные на базе интернет-аналитики выводы, превозмогая сложившуюся непростую экономическую ситуацию, указаны как претенденты на роль ключевых факторов. Имеется спорная точка зрения, гласящая примерно следующее: интерактивные прототипы и по сей день остаются уделом либералов, которые жаждут быть превращены в посмешище, хотя само их существование приносит несомненную пользу обществу. С другой стороны, постоянный количественный рост и сфера нашей активности выявляет срочную потребность соответствующих условий активизации.", cover_image="https://c.wallhere.com/photos/91/30/1920x1200_px_animals_big_cats_leopard_nature_Open_Mouth_Snow_Leopards-726079.jpg!d"},
            new post { title="Снежный барс на отдыхе", content="Сделанные на базе интернет-аналитики выводы, превозмогая сложившуюся непростую экономическую ситуацию, указаны как претенденты на роль ключевых факторов. Имеется спорная точка зрения, гласящая примерно следующее: интерактивные прототипы и по сей день остаются уделом либералов, которые жаждут быть превращены в посмешище, хотя само их существование приносит несомненную пользу обществу. С другой стороны, постоянный количественный рост и сфера нашей активности выявляет срочную потребность соответствующих условий активизации.", cover_image="https://i.pinimg.com/originals/85/03/5f/85035f7e939fcc99b4de9d0703cf4513.jpg"},
        };
        public int take_count = 2;
        public int count => _posts.Count;
        public List<post> next_posts(int skip_count) => _posts.Skip(skip_count).Take(take_count).ToList();
    }
}
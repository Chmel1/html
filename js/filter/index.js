const fruktiki = ["Яблоко","Апельсин","Мандарин","Киви"];
for (fruktik of fruktiki)
    {
        console.log(fruktik);
    }
console.log("Короткие фрукты:",fruktiki.filter((frukt) => frukt.length <=6));

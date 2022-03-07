class Program 
{
    static void Main(string[] args){
        using (var context = new BlogDataContext())
{
    //CREATE
    var tag = new Tag { 
    Name = "ASP.NET", 
    Slug = "ASPNET"};
    context.Tags.Add(tag);
    context.SaveChanges();

    //UPDATE
    var tar = context.Tags.FirstOrDefault(x => x.Id == 2);
    tag.Name = ".NET";
    tag.SLUG = "dotnet";
    context.Update(tag);
    context.SaveChanges();

    //DELETE
    var tar = context.Tags.FirstOrDefault(x => x.Id == 2);
    context.Remove(tag);
    context.SaveChanges();

    //READ - SELECT - LEITURA PARA MOSTRAR NA TELA
    var tags = context
    .Tags
    .ToList()
    .Where(x=>x.Name(Contains(".NET"))); // ou
    //.Where(x=>x.Id == 2)
    foreach ( var item in tags)
    {
        Console.WriteLine(tag.Name);
        Console.WriteLine(tag.Slug);


    }    


    }
}


}







}
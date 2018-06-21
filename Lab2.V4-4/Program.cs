namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Univercity U = new Univercity("test");
            Default.DefaultUnivercity(U);
            Menu.ShowMenu(U);

            //         var orgDto = Mapper.GetOrganizationDto(U);
            //       Serializer.ToXml(orgDto, @"file");
            //     var dto = Serializer.FromXml<UnivercityF>(@"file");
            //       var result = new Univercity(dto);
            //       Reporter.Show(result);

            //Create univercity = new Create();
            //univercity.Default();
            //univercity.Menu();
            // Univercity.CreateUnivercity();
        }       
    }
}

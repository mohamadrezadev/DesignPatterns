
CheckUserAcitveUser checkUserAcitveUser = new CheckUserAcitveUser();
CreateOrder createOrder = new CreateOrder();
SendToDriver sendToDriver = new SendToDriver();
CheckTest checkTest = new CheckTest();

checkUserAcitveUser
    .Set_Successor(checkTest)
    .Set_Successor(createOrder)
    .Set_Successor(sendToDriver);


 checkUserAcitveUser.Excute(new RequestContext
{
    UserId = 1,
    origin = new Point { Lat = 53.66, lng = 65.5 },
    Destination = new Point { Lat = 96.6, lng = 48.6 }
});

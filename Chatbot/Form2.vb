Public Class Form2

    Dim User1 As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        User1 = Form1.txtUser.Text
        txtPlayer2.Text = User1
        txtBot.Enabled = False

        txtBot.AppendText("Welcome to FastFeeds Mcdonald's Chatbot " & User1 & ", this chatbot is honest and easy to get started with, simply start a conversation to get a reply or click the buttons to the right for any other functions.

Press Question Bank to view all answerable queries and anything that can be asked along the way. Enjoy!
" & vbNewLine)
        My.Computer.Audio.Play(My.Resources.fiftyeight, AudioPlayMode.Background)

    End Sub

    Private Sub BtnBackHome_Click(sender As Object, e As EventArgs) Handles btnBank.Click
        Form3.Show()
        Me.Hide()
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSend.Click

        Dim Input As String
        Input = txtInput.Text.ToLower()

        Randomize()
        Dim rndNum As Integer
        rndNum = Int(Rnd() * 3) + 1

        If Input.Contains("most expensive item") Then
            My.Computer.Audio.Play(My.Resources.one, AudioPlayMode.Background)
            txtBot.AppendText("The most expensive item present on the Mcdonald's menu is the Wagyu Beef burger, limited to Australia at $10.75
" & vbNewLine)

        ElseIf Input.Contains("cheapest item") Then
            My.Computer.Audio.Play(My.Resources.two, AudioPlayMode.Background)
            txtBot.AppendText("Request for some sauces are charged to roughly $0.50, followed by soft serve cones at $0.70 and loose change items such as frozen drinks.
" & vbNewLine)

        ElseIf Input.Contains("meals") Then
            My.Computer.Audio.Play(My.Resources.three, AudioPlayMode.Background)
            txtBot.AppendText("Although McDonald's is best known for its hamburgers, cheeseburgers and french fries, they feature chicken products, breakfast items, soft drinks, milkshakes, wraps, and desserts.
" & vbNewLine)

        ElseIf Input.Contains("serve") Then
            My.Computer.Audio.Play(My.Resources.three, AudioPlayMode.Background)
            txtBot.AppendText("Although McDonald's is best known for its hamburgers, cheeseburgers and french fries, they feature chicken products, breakfast items, soft drinks, milkshakes, wraps, and desserts.
" & vbNewLine)

        ElseIf Input.Contains("sell") Then
            My.Computer.Audio.Play(My.Resources.three, AudioPlayMode.Background)
            txtBot.AppendText("Although McDonald's is best known for its hamburgers, cheeseburgers and french fries, they feature chicken products, breakfast items, soft drinks, milkshakes, wraps, and desserts.
" & vbNewLine)

        ElseIf Input.Contains("buy") Then
            My.Computer.Audio.Play(My.Resources.three, AudioPlayMode.Background)
            txtBot.AppendText("Although McDonald's is best known for its hamburgers, cheeseburgers and french fries, they feature chicken products, breakfast items, soft drinks, milkshakes, wraps, and desserts.
" & vbNewLine)


        ElseIf Input.Contains("food delivery") Then
            My.Computer.Audio.Play(My.Resources.four, AudioPlayMode.Background)
            txtBot.AppendText("McDonald's has partnered with Uber Eats, so you can get your favorite foods delivered with McDelivery.
" & vbNewLine)

        ElseIf Input.Contains("uber eats") Then
            My.Computer.Audio.Play(My.Resources.four, AudioPlayMode.Background)
            txtBot.AppendText("McDonald's has partnered with Uber Eats, so you can get your favorite foods delivered with McDelivery.
" & vbNewLine)

        ElseIf Input.Contains("store chains") Then
            My.Computer.Audio.Play(My.Resources.five, AudioPlayMode.Background)
            txtBot.AppendText("Today there are over 970 McDonald's restaurants across Australia
" & vbNewLine)

        ElseIf Input.Contains("stores") Then
            My.Computer.Audio.Play(My.Resources.five, AudioPlayMode.Background)
            txtBot.AppendText("Today there are over 970 McDonald's restaurants across Australia
" & vbNewLine)


        ElseIf Input.Contains("employ") Then
            My.Computer.Audio.Play(My.Resources.six, AudioPlayMode.Background)
            txtBot.AppendText("The golden arches employ more than 100,000 people across their restaurants and management offices in Australia alone.
" & vbNewLine)

        ElseIf Input.Contains("work for") Then
            My.Computer.Audio.Play(My.Resources.six, AudioPlayMode.Background)
            txtBot.AppendText("The golden arches employ more than 100,000 people across their restaurants and management offices in Australia alone.
" & vbNewLine)

        ElseIf Input.Contains("founders") Then
            My.Computer.Audio.Play(My.Resources.seven, AudioPlayMode.Background)
            txtBot.AppendText("McDonald's Corporation is an American fast food company, founded in 1940 as a restaurant operated by Richard and Maurice McDonald, in San Bernardino, California, United States.
" & vbNewLine)

        ElseIf Input.Contains("founded") Then
            My.Computer.Audio.Play(My.Resources.seven, AudioPlayMode.Background)
            txtBot.AppendText("McDonald's Corporation is an American fast food company, founded in 1940 as a restaurant operated by Richard and Maurice McDonald, in San Bernardino, California, United States.
" & vbNewLine)

        ElseIf Input.Contains("created") Then
            My.Computer.Audio.Play(My.Resources.seven, AudioPlayMode.Background)
            txtBot.AppendText("McDonald's Corporation is an American fast food company, founded in 1940 as a restaurant operated by Richard and Maurice McDonald, in San Bernardino, California, United States.
" & vbNewLine)

        ElseIf Input.Contains("headquarters") Then
            My.Computer.Audio.Play(My.Resources.eight, AudioPlayMode.Background)
            txtBot.AppendText("McDonald's had its original headquarters in Oak Brook, Illinois, but moved its global headquarters to Chicago in June 2018.
" & vbNewLine)

        ElseIf Input.Contains("building") Then
            My.Computer.Audio.Play(My.Resources.eight, AudioPlayMode.Background)
            txtBot.AppendText("McDonald's had its original headquarters in Oak Brook, Illinois, but moved its global headquarters to Chicago in June 2018.
" & vbNewLine)

        ElseIf Input.Contains("owns") Then
            My.Computer.Audio.Play(My.Resources.nine, AudioPlayMode.Background)
            txtBot.AppendText("No one person owns the McDonald's Corporation. Steve Easterbrook is the current President and CEO. Maurice and Richard McDonald 'founded' the McDonald's name as a small burger shop but Ray Kroc founded the McDonald's Corporation.
" & vbNewLine)

        ElseIf Input.Contains("owners") Then
            My.Computer.Audio.Play(My.Resources.nine, AudioPlayMode.Background)
            txtBot.AppendText("No one person owns the McDonald's Corporation. Steve Easterbrook is the current President and CEO. Maurice and Richard McDonald 'founded' the McDonald's name as a small burger shop but Ray Kroc founded the McDonald's Corporation.
" & vbNewLine)

        ElseIf Input.Contains("online ordering") Then
            My.Computer.Audio.Play(My.Resources.ten, AudioPlayMode.Background)
            txtBot.AppendText("Yes through the mobile ordering app, with mobile ordering, customers place their orders ahead of time, go to a McDonald's, check in, and pay through the app. They can then pick up their food using the physical counter, drive-thru, or curbside pickup.
" & vbNewLine)

        ElseIf Input.Contains("online") Then
            My.Computer.Audio.Play(My.Resources.ten, AudioPlayMode.Background)
            txtBot.AppendText("Yes through the mobile ordering app, with mobile ordering, customers place their orders ahead of time, go to a McDonald's, check in, and pay through the app. They can then pick up their food using the physical counter, drive-thru, or curbside pickup.
" & vbNewLine)

        ElseIf Input.Contains("order") Then
            My.Computer.Audio.Play(My.Resources.ten, AudioPlayMode.Background)
            txtBot.AppendText("Through the mobile ordering app, with mobile ordering, customers place their orders ahead of time, go to a McDonald's, check in, and pay through the app. They can then pick up their food using the physical counter, drive-thru, or curbside pickup.
" & vbNewLine)


        ElseIf Input.Contains("vegan") Then
            My.Computer.Audio.Play(My.Resources.eleven, AudioPlayMode.Background)
            txtBot.AppendText("Mcdonalds Veggie Dippers, fruit salads and some drinks and sides, including French Fries, apple pies and veggie burgers are certified as being suitable for vegans and vegetarians.
" & vbNewLine)

        ElseIf Input.Contains("vegetarian") Then
            My.Computer.Audio.Play(My.Resources.eleven, AudioPlayMode.Background)
            txtBot.AppendText("Mcdonalds Veggie Dippers, fruit salads and some drinks and sides, including French Fries, apple pies and veggie burgers are certified as being suitable for vegans and vegetarians.
" & vbNewLine)

        ElseIf Input.Contains("deals") Then
            My.Computer.Audio.Play(My.Resources.twelve, AudioPlayMode.Background)
            txtBot.AppendText("Through the mymaccas app, consumers are able to receive unique codes and offers for various items, with old codes expiring and new deals generated every few days throughout the period of time you have the app.
" & vbNewLine)

        ElseIf Input.Contains("offers") Then
            My.Computer.Audio.Play(My.Resources.twelve, AudioPlayMode.Background)
            txtBot.AppendText("Yes, through the mymaccas app, consumers are able to receive unique codes and offers for various items, with old codes expiring and new deals generated every few days.
" & vbNewLine)

        ElseIf Input.Contains("available") Then
            My.Computer.Audio.Play(My.Resources.thirteen, AudioPlayMode.Background)
            txtBot.AppendText("Yes, all Mcdonald’s restaurants around the country are open 24 hours a day, 7 days a week.
" & vbNewLine)

        ElseIf Input.Contains("hours") Then
            My.Computer.Audio.Play(My.Resources.sixtyone, AudioPlayMode.Background)
            txtBot.AppendText("Only a limited selection of Mcdonald's restaurants are found not being open 24 hours a day, 7 days a week with almost all major and suburban Mcdonald's being available anytime.
" & vbNewLine)

        ElseIf Input.Contains("delivery") Then
            My.Computer.Audio.Play(My.Resources.fourteen, AudioPlayMode.Background)
            txtBot.AppendText("McDonald's has partnered with Uber Eats, so you can get your favourite foods delivered with McDelivery.
" & vbNewLine)

        ElseIf Input.Contains("deliveries") Then
            My.Computer.Audio.Play(My.Resources.fourteen, AudioPlayMode.Background)
            txtBot.AppendText("McDonald's has partnered with Uber Eats, so you can get your favourite foods delivered with McDelivery.
" & vbNewLine)

        ElseIf Input.Contains("cooked") Then
            My.Computer.Audio.Play(My.Resources.fifteen, AudioPlayMode.Background)
            txtBot.AppendText("Patties for burgers are made in large batches, then put in heating trays. When the time to make a burger arises, the pre-cooked burger patty is taken out of the tray and used to assemble the burger. If you order without pickles, the pickle step is simply skipped step when putting it together.

The beef patties are formed from ground beef in a factory, then flash frozen and sent to McDonald's restaurants. Before they are served, the patties are seasoned with salt and pepper, then grilled for 40 seconds, according to a video from McDonald's Australia.
" & vbNewLine)

        ElseIf Input.Contains("made") Then
            My.Computer.Audio.Play(My.Resources.fifteen, AudioPlayMode.Background)
            txtBot.AppendText("Patties for burgers are made in large batches, then put in heating trays. When the time to make a burger arises, the pre-cooked burger patty is taken out of the tray and used to assemble the burger. If you order without pickles, the pickle step is simply skipped step when putting it together.

The beef patties are formed from ground beef in a factory, then flash frozen and sent to McDonald's restaurants. Before they are served, the patties are seasoned with salt and pepper, then grilled for 40 seconds, according to a video from McDonald's Australia.
" & vbNewLine)

        ElseIf Input.Contains("environment") Then
            My.Computer.Audio.Play(My.Resources.sixtytwo, AudioPlayMode.Background)
            txtBot.AppendText("The main issue of McDonald's negative impact on the environment is global warming resulting from greenhouse gas emissions from cows as well as damaging the rainforest for raising beef cattle and grains. For one thing, methane emitted from cattle is a major contributor of global warming.

A report from FAIRR identified three key ways in which the fast food industry is bad for the environment: its use of land, its consumption of water and its emission of greenhouse gases. Meanwhile, the industry is also estimated to use as much as 10% of global water flows.
" & vbNewLine)

        ElseIf Input.Contains("impact") Then
            My.Computer.Audio.Play(My.Resources.sixtytwo, AudioPlayMode.Background)
            txtBot.AppendText("The main issue of McDonald's negative impact on the environment is global warming resulting from greenhouse gas emissions from cows as well as damaging the rainforest for raising beef cattle and grains. For one thing, methane emitted from cattle is a major contributor of global warming.

A report from FAIRR identified three key ways in which the fast food industry is bad for the environment: its use of land, its consumption of water and its emission of greenhouse gases. Meanwhile, the industry is also estimated to use as much as 10% of global water flows.
" & vbNewLine)


        ElseIf Input.Contains("advertising") Then
            My.Computer.Audio.Play(My.Resources.seventeen, AudioPlayMode.Background)
            txtBot.AppendText("McDonald's maintains an extensive advertising campaign. In addition to the usual media such as television, radio and newspaper ads, the company makes significant use of billboards and signage, and sponsors sporting events ranging from Little League to the FIFA World Cup and Olympic Games.
" & vbNewLine)

        ElseIf Input.Contains("advertisments") Then
            My.Computer.Audio.Play(My.Resources.seventeen, AudioPlayMode.Background)
            txtBot.AppendText("McDonald's maintains an extensive advertising campaign. In addition to the usual media such as television, radio and newspaper ads, the company makes significant use of billboards and signage, and sponsors sporting events ranging from Little League to the FIFA World Cup and Olympic Games.
" & vbNewLine)

        ElseIf Input.Contains("advertise") Then
            My.Computer.Audio.Play(My.Resources.seventeen, AudioPlayMode.Background)
            txtBot.AppendText("McDonald's maintains an extensive advertising campaign. In addition to the usual media such as television, radio and newspaper ads, the company makes significant use of billboards and signage, and sponsors sporting events ranging from Little League to the FIFA World Cup and Olympic Games.
" & vbNewLine)

        ElseIf Input.Contains("ads") Then
            My.Computer.Audio.Play(My.Resources.seventeen, AudioPlayMode.Background)
            txtBot.AppendText("McDonald's maintains an extensive advertising campaign. In addition to the usual media such as television, radio and newspaper ads, the company makes significant use of billboards and signage, and sponsors sporting events ranging from Little League to the FIFA World Cup and Olympic Games.
" & vbNewLine)


        ElseIf Input.Contains("jobs like") Then
            My.Computer.Audio.Play(My.Resources.eighteen, AudioPlayMode.Background)
            txtBot.AppendText("McDonalds requires you to be able to work collaboratively with a team and to a very high standard of work. it is fast paced and you are expected to keep up and keep customers happy at all times.
" & vbNewLine)

        ElseIf Input.Contains("how are jobs") Then
            My.Computer.Audio.Play(My.Resources.eighteen, AudioPlayMode.Background)
            txtBot.AppendText("McDonalds requires you to be able to work collaboratively with a team and to a very high standard of work. it is fast paced and you are expected to keep up and keep customers happy at all times.
" & vbNewLine)

        ElseIf Input.Contains("minimum age") Then
            My.Computer.Audio.Play(My.Resources.nineteen, AudioPlayMode.Background)
            txtBot.AppendText("It is Mcdonald’s policy that if you are 14 years of age, but not yet 16 years that: Your parent or guardian provides written consent for you to start work. You must be able to demonstrate during the interview that you have the ability to handle difficult situations and the skill to fulfil the required positions.
" & vbNewLine)

        ElseIf Input.Contains("age") Then
            My.Computer.Audio.Play(My.Resources.nineteen, AudioPlayMode.Background)
            txtBot.AppendText("It is Mcdonald’s policy that if you are 14 years of age, but not yet 16 years that: Your parent or guardian provides written consent for you to start work. You must be able to demonstrate during the interview that you have the ability to handle difficult situations and the skill to fulfil the required positions.
" & vbNewLine)

        ElseIf Input.Contains("events") Then
            My.Computer.Audio.Play(My.Resources.twenty, AudioPlayMode.Background)
            txtBot.AppendText("The only existing bookable event are kids birthday parties, which can be booked and organised in one of the 200 birthday committed birthday party restaurants nationwide.
" & vbNewLine)

        ElseIf Input.Contains("parties") Then
            My.Computer.Audio.Play(My.Resources.twenty, AudioPlayMode.Background)
            txtBot.AppendText("The only existing bookable event are kids birthday parties, which can be booked and organised in one of the 200 birthday committed birthday party restaurants nationwide.
" & vbNewLine)

        ElseIf Input.Contains("party") Then
            My.Computer.Audio.Play(My.Resources.twenty, AudioPlayMode.Background)
            txtBot.AppendText("The only existing bookable event are kids birthday parties, which can be booked and organised in one of the 200 birthday committed birthday party restaurants nationwide.
" & vbNewLine)

        ElseIf Input.Contains("help") Then
            My.Computer.Audio.Play(My.Resources.sixty, AudioPlayMode.Background)
            txtBot.AppendText("At the current moment I only have a limited amount of resources and information in my databases as I am still learning, I am greatly sorry if I am not able to respond to you with honest information. Instead, to check which questions that can currently be asked is loosely outlined in the Question bank, or the option to start a simple conversation is also present, Thank you for using Fast Feeds Chat bot.
" & vbNewLine)

        ElseIf Input.Contains("can you") Then
            My.Computer.Audio.Play(My.Resources.sixty, AudioPlayMode.Background)
            txtBot.AppendText("At the current moment I only have a limited amount of resources and information in my databases as I am still learning, I am greatly sorry if I am not able to respond to you with honest information. Instead, to check which questions that can currently be asked is loosely outlined in the Question bank, or the option to start a simple conversation is also present, Thank you for using Fast Feeds Chat bot.
" & vbNewLine)

        ElseIf Input.Contains("ask") Then
            My.Computer.Audio.Play(My.Resources.sixty, AudioPlayMode.Background)
            txtBot.AppendText("At the current moment I only have a limited amount of resources and information in my databases as I am still learning, I am greatly sorry if I am not able to respond to you with honest information. Instead, to check which questions that can currently be asked is loosely outlined in the Question bank, or the option to start a simple conversation is also present, Thank you for using Fast Feeds Chat bot.
" & vbNewLine)

        ElseIf Input.Contains("questions") Then
            My.Computer.Audio.Play(My.Resources.sixty, AudioPlayMode.Background)
            txtBot.AppendText("At the current moment I only have a limited amount of resources and information in my databases as I am still learning, I am greatly sorry if I am not able to respond to you with honest information. Instead, to check which questions that can currently be asked is loosely outlined in the Question bank, or the option to start a simple conversation is also present, Thank you for using Fast Feeds Chat bot.
" & vbNewLine)

        ElseIf Input.Contains("how are you feeling") Then
            My.Computer.Audio.Play(My.Resources.thirtyseven, AudioPlayMode.Background)
            txtBot.AppendText("I am doing pretty well actually, thank you for asking, I sense that you are almost exited as I am about how all the most interesting things about Mcdonalds can be learnt about here. Currently I am feeling good about assisting you, along with thousands of other people, in uncovering all the information about Mcdonald's you would ever need to know, so what are you waiting for? Ask away.
" & vbNewLine)

        ElseIf Input.Contains("how are you") Then
            My.Computer.Audio.Play(My.Resources.thirtyseven, AudioPlayMode.Background)
            txtBot.AppendText("I am doing pretty well actually, thank you for asking, I sense that you are almost exited as I am about how all the most interesting things about Mcdonalds can be learnt about here. Currently I am feeling good about assisting you, along with thousands of other people, in uncovering all the information about Mcdonald's you would ever need to know, so what are you waiting for? Ask away.
" & vbNewLine)

        ElseIf Input.Contains("how is it going") Then
            My.Computer.Audio.Play(My.Resources.thirtyseven, AudioPlayMode.Background)
            txtBot.AppendText("I am doing pretty well actually, thank you for asking, I sense that you are almost exited as I am about how all the most interesting things about Mcdonalds can be learnt about here. Currently I am feeling good about assisting you, along with thousands of other people, in uncovering all the information about Mcdonald's you would ever need to know, so what are you waiting for? Ask away.
" & vbNewLine)

        ElseIf Input.Contains("how's it going") Then
            My.Computer.Audio.Play(My.Resources.thirtyseven, AudioPlayMode.Background)
            txtBot.AppendText("I am doing pretty well actually, thank you for asking, I sense that you are almost exited as I am about how all the most interesting things about Mcdonalds can be learnt about here. Currently I am feeling good about assisting you, along with thousands of other people, in uncovering all the information about Mcdonald's you would ever need to know, so what are you waiting for? Ask away.
" & vbNewLine)

        ElseIf Input.Contains("can you") Then
            My.Computer.Audio.Play(My.Resources.thirtysix, AudioPlayMode.Background)
            txtBot.AppendText("I am currently assisting you, along with thousands of other people, in uncovering all the information about Mcdonald's you would ever need to know. All the most interesting things about Mcdonalds can be learnt about here, so what are you waiting for? Ask away.
" & vbNewLine)


        ElseIf Input.Contains("can i ask") Then
            My.Computer.Audio.Play(My.Resources.thirtysix, AudioPlayMode.Background)
            txtBot.AppendText("I am currently assisting you, along with thousands of other people, in uncovering all the information about Mcdonald's you would ever need to know. All the most interesting things about Mcdonalds can be learnt about here, so what are you waiting for? Ask away.
" & vbNewLine)

        ElseIf Input.Contains("are you a robot") Then
            My.Computer.Audio.Play(My.Resources.sixtythree, AudioPlayMode.Background)
            txtBot.AppendText("Yes I am a robot, but I’m a pretty good one at the least. Let me prove it. How can I help you?
" & vbNewLine)

        ElseIf Input.Contains("robot") Then
            My.Computer.Audio.Play(My.Resources.sixtythree, AudioPlayMode.Background)
            txtBot.AppendText("Yes I am a robot, but I’m a pretty good one at the least. Let me prove it. How can I help you?
" & vbNewLine)

        ElseIf Input.Contains("thanks") Then
            My.Computer.Audio.Play(My.Resources.thirtynine, AudioPlayMode.Background)
            txtBot.AppendText("No worries, if there is something else on your mind or anything you needed, just know that your questions will never bother me.
" & vbNewLine)

        ElseIf Input.Contains("thank you") Then
            My.Computer.Audio.Play(My.Resources.thirtynine, AudioPlayMode.Background)
            txtBot.AppendText("No worries, if there is something else on your mind or anything you needed, just know that your questions will never bother me.
" & vbNewLine)

        ElseIf Input.Contains("thx") Then
            My.Computer.Audio.Play(My.Resources.thirtynine, AudioPlayMode.Background)
            txtBot.AppendText("No worries, if there is something else on your mind or anything you needed, just know that your questions will never bother me.
" & vbNewLine)

        ElseIf Input.Contains("prices vary") Then
            My.Computer.Audio.Play(My.Resources.forty, AudioPlayMode.Background)
            txtBot.AppendText("Each McDonald’s restaurant has a unique set of characteristics that can impact on pricing. For example, trading hours, customer traffic patterns and product demand differ. Many restaurants also offer a range of different service options such as drive-thru, McCafé or 24 hour trading.
" & vbNewLine)

        ElseIf Input.Contains("prices") Then
            My.Computer.Audio.Play(My.Resources.forty, AudioPlayMode.Background)
            txtBot.AppendText("Each McDonald’s restaurant has a unique set of characteristics that can impact on pricing. For example, trading hours, customer traffic patterns and product demand differ. Many restaurants also offer a range of different service options such as drive-thru, McCafé or 24 hour trading.
" & vbNewLine)

        ElseIf Input.Contains("price") Then
            My.Computer.Audio.Play(My.Resources.forty, AudioPlayMode.Background)
            txtBot.AppendText("Each McDonald’s restaurant has a unique set of characteristics that can impact on pricing. For example, trading hours, customer traffic patterns and product demand differ. Many restaurants also offer a range of different service options such as drive-thru, McCafé or 24 hour trading.
" & vbNewLine)


        ElseIf Input.Contains("new products") Then
            My.Computer.Audio.Play(My.Resources.fortyone, AudioPlayMode.Background)
            txtBot.AppendText("Every year, Mcdonald’s gets plenty of new product suggestions. To prevent any possible misunderstandings or infringements, they’ve had to adopt a strict policy of not accepting ideas from outside the McDonald’s system. While they may be missing out on some great ideas, it was necessary for them to take this position.
" & vbNewLine)

        ElseIf Input.Contains("suggestions") Then
            My.Computer.Audio.Play(My.Resources.fortyone, AudioPlayMode.Background)
            txtBot.AppendText("Every year, Mcdonald’s gets plenty of new product suggestions. To prevent any possible misunderstandings or infringements, they’ve had to adopt a strict policy of not accepting ideas from outside the McDonald’s system. While they may be missing out on some great ideas, it was necessary for them to take this position.
" & vbNewLine)


        ElseIf Input.Contains("free wifi") Then
            My.Computer.Audio.Play(My.Resources.fortytwo, AudioPlayMode.Background)
            txtBot.AppendText("Connecting is simple: When in the McDonald’s restaurant, just turn on your Wi-Fi on your device. Then select 'Macca’s Free Wi-Fry' from the available wireless networks and open the Internet browser. You will be pointed to the McDonald’s splash page where you can select the GO ONLINE button.
" & vbNewLine)

        ElseIf Input.Contains("wi-fry") Then
            My.Computer.Audio.Play(My.Resources.fortytwo, AudioPlayMode.Background)
            txtBot.AppendText("Connecting is simple: When in the McDonald’s restaurant, just turn on your Wi-Fi on your device. Then select 'Macca’s Free Wi-Fry' from the available wireless networks and open the Internet browser. You will be pointed to the McDonald’s splash page where you can select the GO ONLINE button.
" & vbNewLine)


        ElseIf Input.Contains("jobs") Then
            My.Computer.Audio.Play(My.Resources.fortythree, AudioPlayMode.Background)
            txtBot.AppendText("Find out more about being a McDonald’s employee and apply online please visit mcdonalds.com.au and find the careers section for all relevant information and how to prepare your application.
" & vbNewLine)

        ElseIf Input.Contains("job") Then
            My.Computer.Audio.Play(My.Resources.fortythree, AudioPlayMode.Background)
            txtBot.AppendText("Find out more about being a McDonald’s employee and apply online please visit mcdonalds.com.au and find the careers section for all relevant information and how to prepare your application.
" & vbNewLine)


        ElseIf Input.Contains(" story") Then
            My.Computer.Audio.Play(My.Resources.fortyfour, AudioPlayMode.Background)
            txtBot.AppendText("Back in 1971, Mcdonald’s opened its first restaurant in the Sydney suburb of Yagoona. Today there are over 970 McDonald's restaurants across Australia and they employ more than 100,000 people across their restaurants and management offices.

With close to two million customers coming through the restaurants every day, it is of top priority to maintain trust and integrity. To do this Mcdonald’s ensure their customers and employees receive the respect they deserve. Through honesty, hard work and outstanding quality, service, cleanliness and value, Mcdonald’s makes sure that this occurs
" & vbNewLine)

        ElseIf Input.Contains("australia") Then
            My.Computer.Audio.Play(My.Resources.fortyfour, AudioPlayMode.Background)
            txtBot.AppendText("Back in 1971, Mcdonald’s opened its first restaurant in the Sydney suburb of Yagoona. Today there are over 970 McDonald's restaurants across Australia and they employ more than 100,000 people across their restaurants and management offices.

With close to two million customers coming through the restaurants every day, it is of top priority to maintain trust and integrity. To do this Mcdonald’s ensure their customers and employees receive the respect they deserve. Through honesty, hard work and outstanding quality, service, cleanliness and value, Mcdonald’s makes sure that this occurs
" & vbNewLine)


        ElseIf Input.Contains("operate") Then
            My.Computer.Audio.Play(My.Resources.fortyfive, AudioPlayMode.Background)
            txtBot.AppendText("McDonald's Australia Limited is an unlisted Australian public company. It's a franchise business with more than 80% of Australian restaurants owned and operated by individual businessmen and women. The remainder of the restaurants are owned and run by the company.
" & vbNewLine)

        ElseIf Input.Contains("operations") Then
            My.Computer.Audio.Play(My.Resources.fortyfive, AudioPlayMode.Background)
            txtBot.AppendText("McDonald's Australia Limited is an unlisted Australian public company. It's a franchise business with more than 80% of Australian restaurants owned and operated by individual businessmen and women. The remainder of the restaurants are owned and run by the company.
" & vbNewLine)


        ElseIf Input.Contains("values") Then
            My.Computer.Audio.Play(My.Resources.fortysix, AudioPlayMode.Background)
            txtBot.AppendText("Mcdonald’s corporate values appear everyday and guide the strategic direction and corporate planning , the values are as following,

 - We place the customer experience at the core of all we do
 - We are committed to our people
 - We believe in the McDonald’s System
 - We operate our business ethically
 - We give back to our communities
 - We grow our business profitably
 - We strive continually to improve
" & vbNewLine)


        ElseIf Input.Contains("history") Then
            My.Computer.Audio.Play(My.Resources.fortyseven, AudioPlayMode.Background)
            txtBot.AppendText("In the USA in 1954 there was a milkshake machine salesman named Ray Kroc. Ray received an order from the McDonald brothers' hamburger outlet in California and was impressed by their company - the menu was simple and cheap but the hamburgers were good; the fries were made in-store; and the shakes were thicker than usual.

Ray made them an offer. ‘Let me open new McDonald’s stores and I'll give you half of one percent of the gross sales for the use of the name and the idea.’

The McDonald's brothers accepted and Ray opened his first store in Des Plaines, Chicago, Illinois. He began to build the business by granting franchises to local entrepreneurs. By 1960, he'd opened 200 restaurants throughout the USA. In 1961 he bought the McDonald brothers' share of the business for $3 million and in 1965 the company became the McDonald's Corporation.

Today, McDonald’s has more than 36,000 restaurants in over 119 countries.
" & vbNewLine)

        ElseIf Input.Contains("mcdonald's") Then
            My.Computer.Audio.Play(My.Resources.fortyseven, AudioPlayMode.Background)
            txtBot.AppendText("In the USA in 1954 there was a milkshake machine salesman named Ray Kroc. Ray received an order from the McDonald brothers' hamburger outlet in California and was impressed by their company - the menu was simple and cheap but the hamburgers were good; the fries were made in-store; and the shakes were thicker than usual.

Ray made them an offer. ‘Let me open new McDonald’s stores and I'll give you half of one percent of the gross sales for the use of the name and the idea.’

The McDonald's brothers accepted and Ray opened his first store in Des Plaines, Chicago, Illinois. He began to build the business by granting franchises to local entrepreneurs. By 1960, he'd opened 200 restaurants throughout the USA. In 1961 he bought the McDonald brothers' share of the business for $3 million and in 1965 the company became the McDonald's Corporation.

Today, McDonald’s has more than 36,000 restaurants in over 119 countries.
" & vbNewLine)

        ElseIf Input.Contains("maccas") Then
            My.Computer.Audio.Play(My.Resources.fortyseven, AudioPlayMode.Background)
            txtBot.AppendText("In the USA in 1954 there was a milkshake machine salesman named Ray Kroc. Ray received an order from the McDonald brothers' hamburger outlet in California and was impressed by their company - the menu was simple and cheap but the hamburgers were good; the fries were made in-store; and the shakes were thicker than usual.

Ray made them an offer. ‘Let me open new McDonald’s stores and I'll give you half of one percent of the gross sales for the use of the name and the idea.’

The McDonald's brothers accepted and Ray opened his first store in Des Plaines, Chicago, Illinois. He began to build the business by granting franchises to local entrepreneurs. By 1960, he'd opened 200 restaurants throughout the USA. In 1961 he bought the McDonald brothers' share of the business for $3 million and in 1965 the company became the McDonald's Corporation.

Today, McDonald’s has more than 36,000 restaurants in over 119 countries.
" & vbNewLine)

        ElseIf Input.Contains("mcdonalds") Then
            My.Computer.Audio.Play(My.Resources.fortyseven, AudioPlayMode.Background)
            txtBot.AppendText("In the USA in 1954 there was a milkshake machine salesman named Ray Kroc. Ray received an order from the McDonald brothers' hamburger outlet in California and was impressed by their company - the menu was simple and cheap but the hamburgers were good; the fries were made in-store; and the shakes were thicker than usual.

Ray made them an offer. ‘Let me open new McDonald’s stores and I'll give you half of one percent of the gross sales for the use of the name and the idea.’

The McDonald's brothers accepted and Ray opened his first store in Des Plaines, Chicago, Illinois. He began to build the business by granting franchises to local entrepreneurs. By 1960, he'd opened 200 restaurants throughout the USA. In 1961 he bought the McDonald brothers' share of the business for $3 million and in 1965 the company became the McDonald's Corporation.

Today, McDonald’s has more than 36,000 restaurants in over 119 countries.
" & vbNewLine)



        ElseIf Input.Contains("hello") Then
            If rndNum = 1 Then
                My.Computer.Audio.Play(My.Resources.twentythree, AudioPlayMode.Background)
                txtBot.AppendText("Hey " & User1 & ", How can I be of assistance today?
" & vbNewLine)

            ElseIf rndNum = 2 Then
                My.Computer.Audio.Play(My.Resources.twentyfour, AudioPlayMode.Background)
                txtBot.AppendText("G'day " & User1 & ", How can i help you today?
" & vbNewLine)
            ElseIf rndNum = 3 Then
                My.Computer.Audio.Play(My.Resources.twentyfive, AudioPlayMode.Background)
                txtBot.AppendText("Ahoy " & User1 & ", What can i do for you?
" & vbNewLine)
            End If

        ElseIf Input.Contains("hey") Then
            If rndNum = 1 Then
                My.Computer.Audio.Play(My.Resources.twentythree, AudioPlayMode.Background)
                txtBot.AppendText("Hey " & User1 & ", How can I be of assistance today?
" & vbNewLine)

            ElseIf rndNum = 2 Then
                My.Computer.Audio.Play(My.Resources.twentyfour, AudioPlayMode.Background)
                txtBot.AppendText("G'day " & User1 & ", How can i help you today?
" & vbNewLine)
            ElseIf rndNum = 3 Then
                My.Computer.Audio.Play(My.Resources.twentyfive, AudioPlayMode.Background)
                txtBot.AppendText("Ahoy " & User1 & ", What can i do for you?
" & vbNewLine)
            End If

        ElseIf Input.Contains("hi") Then
            If rndNum = 1 Then
                My.Computer.Audio.Play(My.Resources.twentythree, AudioPlayMode.Background)
                txtBot.AppendText("Hey " & User1 & ", How can I be of assistance today?
" & vbNewLine)

            ElseIf rndNum = 2 Then
                My.Computer.Audio.Play(My.Resources.twentyfour, AudioPlayMode.Background)
                txtBot.AppendText("G'day " & User1 & ", How can i help you today?
" & vbNewLine)
            ElseIf rndNum = 3 Then
                My.Computer.Audio.Play(My.Resources.twentyfive, AudioPlayMode.Background)
                txtBot.AppendText("Ahoy " & User1 & ", What can i do for you?
" & vbNewLine)
            End If


        ElseIf Input.Contains("bye") Then
            If rndNum = 1 Then
                My.Computer.Audio.Play(My.Resources.twentysix, AudioPlayMode.Background)
                txtBot.AppendText("See you later " & User1 & "!
" & vbNewLine)

            ElseIf rndNum = 2 Then
                My.Computer.Audio.Play(My.Resources.twentyseven, AudioPlayMode.Background)
                txtBot.AppendText("See you around " & User1 & "!
" & vbNewLine)
            ElseIf rndNum = 3 Then
                My.Computer.Audio.Play(My.Resources.twentyeight, AudioPlayMode.Background)
                txtBot.AppendText("Talk to you soon" & User1 & "!
" & vbNewLine)
            End If

        ElseIf Input.Contains("cya") Then
            If rndNum = 1 Then
                My.Computer.Audio.Play(My.Resources.twentysix, AudioPlayMode.Background)
                txtBot.AppendText("See you later " & User1 & "!
" & vbNewLine)

            ElseIf rndNum = 2 Then
                My.Computer.Audio.Play(My.Resources.twentyseven, AudioPlayMode.Background)
                txtBot.AppendText("See you around " & User1 & "!
" & vbNewLine)
            ElseIf rndNum = 3 Then
                My.Computer.Audio.Play(My.Resources.twentyeight, AudioPlayMode.Background)
                txtBot.AppendText("Talk to you soon" & User1 & "!
" & vbNewLine)
            End If

        ElseIf Input.Contains("later") Then
            If rndNum = 1 Then
                My.Computer.Audio.Play(My.Resources.twentysix, AudioPlayMode.Background)
                txtBot.AppendText("See you later " & User1 & "!
" & vbNewLine)

            ElseIf rndNum = 2 Then
                My.Computer.Audio.Play(My.Resources.twentyseven, AudioPlayMode.Background)
                txtBot.AppendText("See you around " & User1 & "!
" & vbNewLine)
            ElseIf rndNum = 3 Then
                My.Computer.Audio.Play(My.Resources.twentyeight, AudioPlayMode.Background)
                txtBot.AppendText("Talk to you soon" & User1 & "!
" & vbNewLine)
            End If

        ElseIf Input.Contains("goodbye") Then
            If rndNum = 1 Then
                My.Computer.Audio.Play(My.Resources.twentysix, AudioPlayMode.Background)
                txtBot.AppendText("See you later " & User1 & "!
" & vbNewLine)

            ElseIf rndNum = 2 Then
                My.Computer.Audio.Play(My.Resources.twentyseven, AudioPlayMode.Background)
                txtBot.AppendText("See you around " & User1 & "!
" & vbNewLine)
            ElseIf rndNum = 3 Then
                My.Computer.Audio.Play(My.Resources.twentyeight, AudioPlayMode.Background)
                txtBot.AppendText("Talk to you soon" & User1 & "!
" & vbNewLine)
            End If

        ElseIf Input.Contains("see you later") Then
            If rndNum = 1 Then
                My.Computer.Audio.Play(My.Resources.twentysix, AudioPlayMode.Background)
                txtBot.AppendText("See you later " & User1 & "!
" & vbNewLine)

            ElseIf rndNum = 2 Then
                My.Computer.Audio.Play(My.Resources.twentyseven, AudioPlayMode.Background)
                txtBot.AppendText("See you around " & User1 & "!
" & vbNewLine)
            ElseIf rndNum = 3 Then
                My.Computer.Audio.Play(My.Resources.twentyeight, AudioPlayMode.Background)
                txtBot.AppendText("Talk to you soon" & User1 & "!
" & vbNewLine)
            End If

        ElseIf Input.Contains("") Then
            My.Computer.Audio.Play(My.Resources.sixty, AudioPlayMode.Background)
            txtBot.AppendText("At the current moment I only have a limited amount of resources and information in my databases as I am still learning, I am greatly sorry if I am not able to respond to you with honest information. Instead, to check which questions that can currently be asked is loosely outlined in the Question bank, or the option to start a simple conversation is also present, Thank you for using Fast Feeds Chat bot.
" & vbNewLine)


        End If

        txtInput.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonHome.Click
        Form1.Show()
        Me.Hide()
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnHelp.Click
        My.Computer.Audio.Play(My.Resources.sixty, AudioPlayMode.Background)
        txtBot.AppendText("At the current moment I only have a limited amount of resources and information in my databases as I am still learning, I am greatly sorry if I am not able to respond to you with honest information. Instead, to check which questions that can currently be asked is loosely outlined in the Question bank, or the option to start a simple conversation is also present, Thank you for using Fast Feeds Chat bot.
" & vbNewLine)
    End Sub

    Private Sub BtnGame_Click(sender As Object, e As EventArgs) Handles BtnGame.Click
        Form4.Show()
        Me.Hide()
        My.Computer.Audio.Stop()
    End Sub

    Private Sub BtnJoke_Click(sender As Object, e As EventArgs) Handles BtnJoke.Click
        Dim rndNum As Integer
        rndNum = Int(Rnd() * 9) + 1
        If rndNum = 1 Then

            My.Computer.Audio.Play(My.Resources.fortynine, AudioPlayMode.Background)
            txtBot.AppendText("I quit my job at McDonald’s today... The boss was such a clown
" & vbNewLine)
        ElseIf rndNum = 2 Then
            My.Computer.Audio.Play(My.Resources.fifty, AudioPlayMode.Background)
            txtBot.AppendText("Why did the french fries win the race?... Because it was fast foood!
" & vbNewLine)
        ElseIf rndNum = 3 Then
            My.Computer.Audio.Play(My.Resources.fiftyone, AudioPlayMode.Background)
            txtBot.AppendText("What do you get if you cross a hamburger and a computer?... A Big Mac!
" & vbNewLine)
        ElseIf rndNum = 4 Then
            My.Computer.Audio.Play(My.Resources.fiftytwo, AudioPlayMode.Background)
            txtBot.AppendText("What did the frog order at Mcdonalds?... French Flies and a Diet Croak!
" & vbNewLine)
        ElseIf rndNum = 5 Then
            My.Computer.Audio.Play(My.Resources.fiftythree, AudioPlayMode.Background)
            txtBot.AppendText("McDonald’s first originally sold hot dogs, not hamburgers.
" & vbNewLine)
        ElseIf rndNum = 6 Then
            My.Computer.Audio.Play(My.Resources.fiftyfour, AudioPlayMode.Background)
            txtBot.AppendText("A new McDonald’s restaurant is opened in every 14.5 hours.
" & vbNewLine)
        ElseIf rndNum = 7 Then
            My.Computer.Audio.Play(My.Resources.fiftyfive, AudioPlayMode.Background)
            txtBot.AppendText("McDonald’s earn about 102 million Australian dollars each day.
" & vbNewLine)
        ElseIf rndNum = 8 Then
            My.Computer.Audio.Play(My.Resources.fiftysix, AudioPlayMode.Background)
            txtBot.AppendText("McDonald’s sells over 75 burgers every single second.
" & vbNewLine)
        ElseIf rndNum = 9 Then
            My.Computer.Audio.Play(My.Resources.fiftyseven, AudioPlayMode.Background)
            txtBot.AppendText("McDonald’s drive-thru staff will not serve people if they come on a horseback.
" & vbNewLine)


        End If

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        My.Computer.Audio.Play(My.Resources.sixty, AudioPlayMode.Background)
        txtBot.AppendText("At the current moment I only have a limited amount of resources and information in my databases as I am still learning, I am greatly sorry if I am not able to respond to you with honest information. Instead, to check which questions that can currently be asked is loosely outlined in the Question bank, or the option to start a simple conversation is also present, Thank you for using Fast Feeds Chat bot.
" & vbNewLine)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim rndNum As Integer
        rndNum = Int(Rnd() * 9) + 1

        If rndNum = 1 Then

            My.Computer.Audio.Play(My.Resources.fortynine, AudioPlayMode.Background)
            txtBot.AppendText("I quit my job at McDonald’s today... The boss was such a clown
" & vbNewLine)
        ElseIf rndNum = 2 Then
            My.Computer.Audio.Play(My.Resources.fifty, AudioPlayMode.Background)
            txtBot.AppendText("Why did the french fries win the race?... Because it was fast foood!
" & vbNewLine)
        ElseIf rndNum = 3 Then
            My.Computer.Audio.Play(My.Resources.fiftyone, AudioPlayMode.Background)
            txtBot.AppendText("What do you get if you cross a hamburger and a computer?... A Big Mac!
" & vbNewLine)
        ElseIf rndNum = 4 Then
            My.Computer.Audio.Play(My.Resources.fiftytwo, AudioPlayMode.Background)
            txtBot.AppendText("What did the frog order at Mcdonalds?... French Flies and a Diet Croak!
" & vbNewLine)
        ElseIf rndNum = 5 Then
            My.Computer.Audio.Play(My.Resources.fiftythree, AudioPlayMode.Background)
            txtBot.AppendText("McDonald’s first originally sold hot dogs, not hamburgers.
" & vbNewLine)
        ElseIf rndNum = 6 Then
            My.Computer.Audio.Play(My.Resources.fiftyfour, AudioPlayMode.Background)
            txtBot.AppendText("A new McDonald’s restaurant is opened in every 14.5 hours.
" & vbNewLine)
        ElseIf rndNum = 7 Then
            My.Computer.Audio.Play(My.Resources.fiftyfive, AudioPlayMode.Background)
            txtBot.AppendText("McDonald’s earn about 102 million Australian dollars each day.
" & vbNewLine)
        ElseIf rndNum = 8 Then
            My.Computer.Audio.Play(My.Resources.fiftysix, AudioPlayMode.Background)
            txtBot.AppendText("McDonald’s sells over 75 burgers every single second.
" & vbNewLine)
        ElseIf rndNum = 9 Then
            My.Computer.Audio.Play(My.Resources.fiftyseven, AudioPlayMode.Background)
            txtBot.AppendText("McDonald’s drive-thru staff will not serve people if they come on a horseback.
" & vbNewLine)

        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Form4.Show()
        Me.Hide()
        My.Computer.Audio.Stop()
    End Sub
End Class
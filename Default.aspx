<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %> 
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html>
<html lang="en" >
	<head>
		<meta charset="utf-8">
		<meta http-equiv="X-UA-Compatible" content="IE=edge">
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<title>Bandung Citweets</title>
		<link href='http://fonts.googleapis.com/css?family=Varela+Round' rel='stylesheet' type='text/css'>
		<link rel="shortcut icon" href="../favicon.ico">
		<link href='http://fonts.googleapis.com/css?family=Raleway:400,300,700' rel='stylesheet' type='text/css'>
        <link href="css/bootstrap.min.css" rel="stylesheet">
		<link href="http://netdna.bootstrapcdn.com/font-awesome/4.1.0/css/font-awesome.min.css" rel="stylesheet">
		<link href="css/flexslider.css" rel="stylesheet" >
		<link href="css/styles.css" rel="stylesheet">
		<link href="css/queries.css" rel="stylesheet">
		<link href="css/animate.css" rel="stylesheet">
		<link rel="stylesheet" href="css/bootstrap.css"/>
		<link rel="stylesheet" href="css/build.css"/>
		<link rel='stylesheet prefetch' href='http://fonts.googleapis.com/css?family=Roboto:400,100,400italic,700italic,700'>
		<script type="text/javascript" src="http://code.jquery.com/jquery-latest.pack.js"></script>
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
		
		<style>
			.awan1 {
				    position: absolute;
				    width: 0%;
				    -webkit-animation-name: example1; /* Chrome, Safari, Opera */
				    -webkit-animation-duration: 0s; /* Chrome, Safari, Opera */
				    -webkit-animation-iteration-count: 0; /* Chrome, Safari, Opera */
				    -webkit-animation-direction: reverse; /* Chrome, Safari, Opera */
				    animation: example1 60s linear infinite reverse;    
				}

				/* Standard syntax */
				@keyframes example1 {
				    0%   {left:500px; top:300px;}
				    50%   {left:0px; top:300px;}
				    100% {left:500px; top:300px;}
				}
			.awan2 {
				    position: absolute;
				    width: 0%;
				    -webkit-animation-name: example2; /* Chrome, Safari, Opera */
				    -webkit-animation-duration: 0s; /* Chrome, Safari, Opera */
				    -webkit-animation-iteration-count: 0; /* Chrome, Safari, Opera */
				    -webkit-animation-direction: reverse; /* Chrome, Safari, Opera */
				    animation: example2 60s linear infinite reverse;    
				}

				/* Standard syntax */
				@keyframes example2 {
				    0%   {left:500px; top:400px;}
				    50%   {left:1000px; top:400px;}
				    100% {left:500px; top:400px;}
				}
			.awan3 {
				    position: absolute;
				    width: 0%;
				    -webkit-animation-name: example3; /* Chrome, Safari, Opera */
				    -webkit-animation-duration: 0s; /* Chrome, Safari, Opera */
				    -webkit-animation-iteration-count: 0; /* Chrome, Safari, Opera */
				    -webkit-animation-direction: reverse; /* Chrome, Safari, Opera */
				    animation: example3 120s linear infinite reverse;    
				}

				/* Standard syntax */
				@keyframes example3 {
				    0%   {left:0px; top:500px;}
				    50%   {left:1000px; top:500px;}
				    100% {left:0px; top:500px;}
				}

            .awan4 {
				    position: absolute;
				    width: 0%;
				    -webkit-animation-name: example4; /* Chrome, Safari, Opera */
				    -webkit-animation-duration: 0s; /* Chrome, Safari, Opera */
				    -webkit-animation-iteration-count: 0; /* Chrome, Safari, Opera */
				    -webkit-animation-direction: reverse; /* Chrome, Safari, Opera */
				    animation: example4 120s linear infinite reverse;    
				}

				/* Standard syntax */
				@keyframes example4 {
				    0%   {left:1000px; top:450px;}
				    50%   {left:0px; top:450px;}
				    100% {left:1000px; top:450px;}
				}

                .modalBackground
                {
                    background-color: Black;
                    filter: alpha(opacity=90);
                    opacity: 0.8;
                }
                .modalPopup
                {
                    padding-top: 10px;
                    padding-left: 10px;
                    width: 1000px;
                    height: 400px;
                }

		</style>
	</head>
	<body id="top">
        <form id="form1" runat="server">
        
		<header id="home">
			<nav>
				<div class="container-fluid">
					<div class="row">
						<div class="col-md-8 col-md-offset-2 col-sm-8 col-sm-offset-2 col-xs-8 col-xs-offset-2">
							<nav class="pull">
								<h7>Tutorial</h7>
								<p>1. Isi semua keyword yang tersedia , untuk keyword lebih dari 1 setiap kategori dipsisahkan "," atau ";"</p>
								<p>2. Pilih metode pencocokan Knuth-Morris-Pratt atau Boyer-Moore</p> 
								<p>3. Klik RUN</p>
								<p>4. Hasil pencarian akan ditampilkan pada bagian Underground</p>
								<p>5. Pilih kategori untuk menemukan hasil pencarian yang diinginkan</p>
							</nav>
						</div>
					</div>
				</div>
			</nav>
		</header>
			<section class="hero" id="city">
				<div class="container">
					<div class="awan1"><img src="img/awan9.png" width="130" height="130" z-index="-1"></div>
					<div class="awan2"><img src="img/awan9.png" width="130" height="130" z-index="-1"></div>
					<div class="awan3"><img src="img/awan9.png" width="130" height="130" z-index="-1"></div>
                    <div class="awan4"><img src="img/awan9.png" width="130" height="130" z-index="-1"></div>
								
					<div class="row">
						<div class="col-md-12 text-right navicon">
							<a id="nav-toggle" class="nav_slide_button" href="#"><span></span></a>
						</div>
					</div>
					<div class="row">
						<div class="col-md-8 col-md-offset-2 text-center inner">
							<h1 class="animated fadeInDown delay-1s">BANDUNG<br>CITWEETS</h1>
							<p1 class="animated fadeInUp delay-2s"><font color = "grey">An exclusive tweets filter for city development</font></p1>
						</div>
					</div>
					
					<div class="row">
						<div class="col-md-8 col-md-offset-2 text-center">
                            <asp:TextBox CssClass="form-control input-lg animated fadeInDown delay-4s" ID="keyword" runat="server" placeholder="Keyword" required></asp:TextBox>
						</div>
					</div> <br>
					<div class="row">
						<div class="col-md-8 col-md-offset-2 text-center">
                            <asp:TextBox CssClass="form-control input-lg animated fadeInDown delay-4s" ID="keydiskes" runat="server" placeholder="Keyword Dinas Kesehatan" required></asp:TextBox>
						</div>
					</div><br>
					<div class="row">
						<div class="col-md-8 col-md-offset-2 text-center">
                            <asp:TextBox CssClass="form-control input-lg animated fadeInDown delay-4s" ID="keydishub" runat="server" placeholder="Keyword Dinas Perhubungan" required></asp:TextBox>
						</div>
					</div><br>
					<div class="row">
						<div class="col-md-8 col-md-offset-2 text-center">
							<asp:TextBox CssClass="form-control input-lg animated fadeInDown delay-4s" ID="keydisdik" runat="server" placeholder="Keyword Dinas Pendidikan" required></asp:TextBox>
						</div>
					</div><br>
					<div class="row">
						<div class="col-md-8 col-md-offset-2 text-center">
                            <asp:TextBox CssClass="form-control input-lg animated fadeInDown delay-4s" ID="keydisbud" runat="server" placeholder="Keyword Dinas Kebudayaan dan Pariwisata" required></asp:TextBox>
						</div>
					</div><br>
					<div class="row">
						<div class="col-md-8 col-md-offset-2 text-center">
							<asp:TextBox CssClass="form-control input-lg animated fadeInDown delay-4s" ID="keydistam" runat="server" placeholder="Keyword Dinas Pertamanan" required></asp:TextBox>
						</div>
					</div>
					<div class="col-md-8 col-md-offset-2 text-center animated fadeInDown delay-4s" style="top:-110px;">
						<div class="checkbox checkbox-success">
                      
							<asp:RadioButton  ID="button_kmp"  runat="server"  GroupName="Algo" Checked/>
							<label for="button_kmp">
								Knuth-Morris-Pratt Algorithm
							</label>
						</div>
						<div class="checkbox checkbox-success" style="">
							<asp:RadioButton  ID="button_bm"  runat="server"  GroupName="Algo"/>
							<label for="button_bm">
								Boyer-Moore Algorithm
							</label>
						</div>
					</div>
					<div class="row">
						<div class="col-md-8 col-md-offset-2 text-center">
							<asp:Button text="RUN" class="learn-more-btn animated fadeInDown delay-4s" id="Button_Search" runat="server" OnClick="button_Search_ServerClick" PostBackUrl="Default.aspx#underground"/></asp:Button>
						</div>
					</div>
					
					<br><br>
					
				</div>
			</section>
		
		<section class="team section-padding" id="underground">
			<div class="container">
				<div>
					<a href="#city"><input type="button" class="main-menu" value="Bandung City"/></a>
				    <a href="#underground"><input type="button" class="main-menu" value="Underground"/></a>
				    <a href="#team"><input type="button" class="main-menu" value="Worker"/></a>
				</div><br><br>
            </div>
				<div class='chat'>
						<header>
						<h4 class='title'>
                          <!-- Nav tabs -->
                          <ul class="nav nav-tabs" role="tablist">
                            <li role="presentation"><a href="#Unknown" role="tab" data-toggle="tab"><img src="img/unknown.png" width="50" heigth="40" /></a></li>
                            <li role="presentation"><a href="#1" role="tab" data-toggle="tab"><img src="img/hospital.png" width="50" heigth="40" /></a></li>
                            <li role="presentation"><a href="#2"  role="tab" data-toggle="tab"><img src="img/bis.jpg" width="50" heigth="40" /></a></li>
                            <li role="presentation"><a href="#3"  role="tab" data-toggle="tab"><img src="img/buku.png" width="50" heigth="40" /></a></li>
                            <li role="presentation"><a href="#4"  role="tab" data-toggle="tab"><img src="img/wayang.png" width="50" heigth="40" /></a></li>
                            <li role="presentation"><a href="#5"  role="tab" data-toggle="tab"><img src="img/taman.png" width="50" heigth="40" /></a></li>
                          </ul>
                        </h4>
                        </header>
                          <!-- Tab panes -->
                          <div class="tab-content">
                         
                            <div role="tabpanel" class="tab-pane" id="Unknown">
                                <div class='body'>
						             <ul>
                                        <li>
								            <div class='content'>
									            <%=cstr %> results
								            </div>
							            </li>
                                        
							            <%=str %>
						            </ul>
					            </div>
                            </div>
                            <div role="tabpanel" class="tab-pane" id="1">
                                <div class='body'>
						            <ul>
                                        <li>
								            <div class='content'>
									            <%=ckes %> results
								            </div>
							            </li>
                                        
							            <%=diskes %>
						            </ul>
					            </div>
                            </div>
                            <div role="tabpanel" class="tab-pane" id="2">
                                <div class='body'>
						            <ul>
                                        <li>
								            <div class='content'>
									            <%=chub %> results
								            </div>
							            </li>
							            <%=dishub %>
						            </ul>
					            </div>
                            </div>
                            <div role="tabpanel" class="tab-pane" id="3">
                                <div class='body'>
						             <ul>
                                        <li>
								            <div class='content'>
									            <%=cdik %> results
								            </div>
							            </li>
                                        <%=disdik %>
						            </ul>
					            </div>
                            </div>
                            <div role="tabpanel" class="tab-pane" id="4">
                                <div class='body'>
						             <ul>
                                        <li>
								            <div class='content'>
									            <%=cbud %> results
								            </div>
							            </li>
                                        <%=disbud %>
						            </ul>
					            </div>
                            </div>
                            <div role="tabpanel" class="tab-pane" id="5">
                                <div class='body'>
						             <ul>
                                        <li>
								            <div class='content'>
									            <%=ctam %> results
								            </div>
							            </li>
							            <%=distam %>
						            </ul>
					            </div>
                            </div>
                            
                          </div>
					</div>
			
			<div class="row">
				<div class="col-md-8 col-md-offset-2 text-center">
                    <a href="#city"><input type="button" class="learn-more-btn2" value="More?"/></a>    
			    </div>
			</div>
		</section>
		<section class="dark-bg text-center section-padding contact-wrap" id="team">
			<a href="#top" class="up-btn"><i class="fa fa-chevron-up"></i></a>
			<div class="container">
				<div class="row">
					<div class="col-md-12">
						<h7 class="arrow">Worker</h7>
					</div>
				</div>
				<div class="row">
					<div class="team-wrapper">
						<div id="teamSlider">
							<ul class="slides">
								<li>
									<div class="col-md-4 wp5">
										<img src="img/raudi.png" height="220" width="220" alt="Team Member">
										<h2>Praditya Raudi</h2>
										<p>Front-end developer, create creative and interactive web interface.</p>
										<div class="social">
											<ul class="social-buttons">
												<li><a href="https://twitter.com/raudipra/" class="social-btn"><i class="fa fa-twitter"></i></a></li>
											</ul>
										</div>
									</div>
								</li>
								<li> 
									<div class="col-md-4 wp5 delay-05s">
										<img src="img/dendi.png" height="220" width="220" alt="Team Member">
										<h2>Dendy Suprihady</h2>
										<p>Back-end developer, create knuth-morris-pratt and boyer-moore algorithm, twitter api and google api.</p>
										<div class="social">
											<ul class="social-buttons">
												<li><a href="https://twitter.com/" class="social-btn"><i class="fa fa-twitter"></i></a></li>
											</ul>
										</div>
									</div>
								</li>
								<li>
									<div class="col-md-4 wp5 delay-1s">
										<img src="img/verisky.png" height="220" width="220" alt="Team Member">
										<h2>Verisky Mega Jaya</h2>
										<p>Back-end developer, create incredible parse for keyword and video maker.</p>
										<div class="social">
											<ul class="social-buttons">
												<li><a href="https://twitter.com/VeriskyMJ" class="social-btn"><i class="fa fa-twitter"></i></a></li>
											</ul>
										</div>
									</div>
								</li>
							</ul>
						</div>
					</div>
					<br>
					<div style="position:relative; top:100px;">
                        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                        <asp:ImageButton ID="btnShow" runat="server" ImageUrl="img/video.png" width="50" height="50" top="100"/>
					</div>
                    <!-- ModalPopupExtender -->
                    <cc1:ModalPopupExtender ID="mp1" runat="server" PopupControlID="Panel1" TargetControlID="btnShow"
                        CancelControlID="btnClose" BackgroundCssClass="modalBackground">
                    </cc1:ModalPopupExtender>
                    <asp:Panel ID="Panel1" runat="server" CssClass="modalPopup" align="center" style = "display:none">
                        <iframe width="560" height="315" src="https://www.youtube.com/embed/UAPplgD4xc8" frameborder="0" allowfullscreen></iframe>
							<br>
                        <asp:Button class="learn-more-btn3" ID="btnClose" runat="server" Text="Close" />
                    </asp:Panel>			
					
				</div>
			</div>
		</section>
        <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
        
        
        <!-- Include all compiled plugins (below), or include individual files as needed -->
        
        <script src="//ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/js/bootstrap.min.js"></script>
        <script src="js/waypoints.min.js"></script>
        <script src="js/bootstrap.min.js"></script>
        <script src="js/jquery.flexslider.js"></script>
        <script src="js/modernizr.js"></script>
        <script src="js/index.js"></script> 
        <script src="js/scripts.js"></script>
        
        </form>
	</body>
</html>


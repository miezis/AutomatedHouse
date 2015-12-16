import react from 'react';
import {Link} from 'react-router';

class Dashboard extends react.Component {
	render() {
		return (
			<nav className="navbar navbar-default navbar-inverse navbar-fixed-top">
				<div className="container-fluid">
					<div className="navbar-header">
						<Link className="navbar-brand" to="/">Automated House</Link>
					</div>
				</div>
			</nav>
		);
	}
}

export default Dashboard;

/*
<div class="container-fluid">
    <div class="navbar-header">
        <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#navbarCollapse">
            <span class="sr-only">Toggle navigation</span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
        </button>
        <a class="navbar-brand" href="#">Tutorial Republic</a>
    </div>
    <!-- Collect the nav links, forms, and other content for toggling -->
    <div class="collapse navbar-collapse" id="navbarCollapse">
        <ul class="nav navbar-nav">
            <li class="active"><a href="http://www.tutorialrepublic.com" target="_blank">Home</a></li>
            <li><a href="http://www.tutorialrepublic.com/about-us.php" target="_blank">About</a></li>
            <li><a href="http://www.tutorialrepublic.com/contact-us.php" target="_blank">Contact</a></li>
        </ul>
    </div>
</div>*/
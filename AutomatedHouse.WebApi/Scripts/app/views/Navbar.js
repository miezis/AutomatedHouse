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
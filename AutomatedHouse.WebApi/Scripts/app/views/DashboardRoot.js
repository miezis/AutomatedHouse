import react from 'react';
import {Link} from 'react-router';

class DashboardRoot extends react.Component {

	render() {
		return (
			<div>
				<div>
					<h1>DashboardRoot</h1>
					<Link to="houses">Houses</Link>
				</div>
				{this.props.children}
			</div>
		);
	}
}

export default DashboardRoot;
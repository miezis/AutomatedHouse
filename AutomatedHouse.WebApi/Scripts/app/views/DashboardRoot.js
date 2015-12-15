import react from 'react';
import {Link} from 'react-router';
import DocumentTitle from 'react-document-title';

class DashboardRoot extends react.Component {

	render() {
		return (
			<div>
				<DocumentTitle title="Dashboard" />
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
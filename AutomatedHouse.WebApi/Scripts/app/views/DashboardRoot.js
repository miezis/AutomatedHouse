import react from 'react';
import {Link} from 'react-router';
import DocumentTitle from 'react-document-title';

import Navbar from './Navbar';

class DashboardRoot extends react.Component {

	render() {
		return (
			<div class="countainer-fluid">
				<DocumentTitle title="Dashboard" />
				<Navbar />
				{this.props.children}
			</div>
		);
	}
}

export default DashboardRoot;
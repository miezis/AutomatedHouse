import _ from 'lodash';
import react from 'react';

class Accessories extends react.Component {
  constructor(props) {
    super(props);
  }
 
  render() {
    const accessories = this.props.accessories;

    if (!accessories.length) {
      return <p>Currently there are no accessories assigned to this room.</p>;
    }

    return (
      <div>
        <h4>Accesories</h4>
        <table className="table table-hover">
          <thead>
            <tr>
              <th>ID</th>
              <th>Name</th>
              <th>Type</th>
              <th>Status</th>
              <th>PIN</th>
            </tr>
          </thead>
          <tbody>
            {_.map(accessories, this.renderAccessory)}
          </tbody>
        </table>
      </div>
    );
  }

  renderAccessory(accessory) {
    return (
      <tr key={accessory.Pin}>
        <td>{accessory.Id}</td>
        <td>{accessory.Name}</td>
        <td>{accessory.Type}</td>
        <td>{accessory.Status === 0 ? 'OFF' : 'ON'}</td>
        <td>{accessory.Pin}</td>
      </tr>
    );
  }
}

export default Accessories;
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
            {_.map(accessories, this.renderAccessory, this)}
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
        <td><p>{accessory.Status === 0 ? 'OFF' : 'ON'}</p><button onClick={this.toggleAccessory.bind(this, accessory)}>Toggle</button></td>
        <td>{accessory.Pin}</td>
      </tr>
    );
  }

  toggleAccessory(accessory, e) {
    e.preventDefault();

    accessory.Status = accessory.Status === 0 ? 1 : 0;

    this.props.updateAccessory(accessory);
  }
}

export default Accessories;
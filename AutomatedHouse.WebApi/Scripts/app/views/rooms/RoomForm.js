import _ from 'lodash';
import react from 'react';

class RoomForm extends react.Component {
  constructor(props) {
    super(props);
  }
 
  render() {
    const props = this.props;

    return (
      <form onSubmit={this.submitForm.bind(this)}>
        <div className="form-group">
          <label htmlFor="name">House Name</label>
          <input id="name" className="form-control" type="text" ref={(ref) => this.nameInput = ref} defaultValue={props.name} />
        </div>
        <button className="btn btn-default" type="submit">Create</button>
      </form>
    );
  }

  submitForm(e) {
    e.preventDefault();

    this.props.onSubmit(this.nameInput.value);
  }
}

export default RoomForm;
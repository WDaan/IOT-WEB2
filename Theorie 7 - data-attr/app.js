class Copter {
    constructor(type, weight, cost, availability) {
        this.type = type;
        this.weight = weight;
        this.cost = cost;
        this.availability = availability;
    }
}

function show(el) {
    const copter = new Copter(el.getAttribute("data-type"), el.getAttribute("data-weight"), el.getAttribute("data-price"), el.getAttribute("data-avail"))
    const content = document.getElementById(copter.type)
    if (!content) {
        draw(el, copter)
    } else {
        content.parentNode.removeChild(content)
    }
}

function draw(el, copter) {
    const string = `
    <div id="${copter.type}" class="card-content">
        <div class="media">
            <div class="content">
                <ul>
                    <li>Type: ${copter.type}</li>
                    <li>weight: ${copter.weight} grams</li>
                    <li>cost: ${copter.price}€</li>
                    <li>availability: ${copter.availability}</li>
                </ul>
            </div>
        </div>
    </div>
    `
    const element = $(string);
    element.appendTo(el);
}
const tf = require('@tensorflow/tfjs');
const iris = require('./iris.json'); // Iris Data Set
const irisT = require('./iris-t.json'); //The extracted Data set, we use to Test the model with


// Optional Load the binding:
// Use '@tensorflow/tfjs-node-gpu' if running with GPU.
require('@tensorflow/tfjs-node');

// Convert/ Setup the Data
// We are taking our iris model and are mapping it, so that the Model Knows The Spezific values for each "Flower" spezimen.
const trainingData = tf.tensor2d(iris.map(flower => [
    flower.sepal_length, flower.sepal_width, flower.petal_length, flower.petal_width
]))

// Here We Tell it which is the correct answer for the Training Data
// When the NN (Neural Networks) works: it trys to guess, which one of these 3 is correct, and with the output data it compares
// and let's the best one "live" and trains further based on this answer
const outputData = tf.tensor2d(iris.map(flower => [
    flower.species == "setosa" ? 1 : 0,
    flower.species == "virginica" ? 1 : 0,
    flower.species == "versicolor" ? 1 : 0,
]))

//The Same as in line 11 just with our testing data
const testingData = tf.tensor2d(irisT.map(flower => [
    flower.sepal_length, flower.sepal_width, flower.petal_length, flower.petal_width
]))

// Build the neural networks
//Initialize the Neural Network
const model = tf.sequential();

// The Input layer for our trainingData
model.add(tf.layers.dense({
    inputShape: [4],
    activation: "sigmoid", // is a Mathematically Function
    units: 5 // The Amount of "neurons"/"brain cells" the layer has inside it
}));

// The First Hidden Layer for Neural Stuff
model.add(tf.layers.dense({
    inputShape: [5],
    activation: "sigmoid",
    units: 3
}));

// The Second Hidden Layer for Neural Stuff
model.add(tf.layers.dense({
    activation: "sigmoid",
    units: 3
}));

//  Error Handling
model.compile({
    loss: "meanSquaredError",
    optimizer: tf.train.adam(.06)
});
//train the neural network
const startTime = Date.now();

// We Train the Model here (explained in line: 17f.)
model.fit(trainingData, outputData, { epochs: 100 }).then(history => {
    //console.log(history)
    console.log("Done", Date.now() - startTime + " ms");
    model.predict(testingData).print(); //Now we test the Model with it trying to predict the species of our testing data
    // The Nearer the Number to one, the more the NN thinks that this is the correct answer
})
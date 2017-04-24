# Enable E2E Diagnostic in a Full-Stack IoT Hub Solution
This tutorial will desmonstrate how to enable end-to-end diagnostic in a full-stack IoT Hub solution.

In this tutorial, you will learn:
* IoT Hub solution architecture
* Setup brand new IoT Hub solution
* Setup IoT Hub solution based on existing IoT Hub and Stream Analytics

## Full-stack IoT Hub solution architecture
FIGURE PALCEHOLDER

## Setup brand new IoT Hub solution

## Setup IoT Hub solution based on existing IoT Hub and Stream Analytics
### Modifying existing IoT Hub
1. Open the existing IoT Hub in Azure portal
2. Click **Metrics** to configure metrics information
3. Check the following metrics from **Available metrics** list, please check the *optional* items if the corresponding endpoints are defined and used:
   * Connected devices
   * Messages delivered to the built-in endpoint (messages/events)
   * Total devices
   * (*optional*) Messages delivered to Event Hub endpoints
   * (*optional*) Messages delivered to Service Bus Queue endpoints
   * (*optional*) Messages delivered to Service Bus Topic endpoints
   
   ![](./Available_Metrics.png)
   
4. Turn on **Diagnostics settings** for **Metrics** as below, then click OK button first, then Save button.
   
   ![](./Metrics_Diagnostics_Settings.png)

### Modifying existing Stream Analytics

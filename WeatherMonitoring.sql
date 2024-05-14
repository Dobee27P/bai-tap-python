CREATE DATABASE WeatherMonitoring;
USE WeatherMonitoring;

-- Table: WeatherData
CREATE TABLE WeatherData (
    id INT PRIMARY KEY IDENTITY(1,1),
    timestamp DATETIME NOT NULL,
    temperature FLOAT NOT NULL,
    humidity FLOAT NOT NULL,
    pressure FLOAT NOT NULL,
    wind_speed FLOAT NOT NULL
);

-- Inserting sample data into WeatherData table
INSERT INTO WeatherData (timestamp, temperature, humidity, pressure, wind_speed) VALUES
('2024-05-01 08:00:00', 25.5, 60, 1012, 5.0),
('2024-05-01 09:00:00', 26.0, 58, 1013, 4.5),
('2024-05-01 10:00:00', 27.0, 55, 1014, 6.0),
('2024-05-14 23:57:00', 27.0, 50,1015,7.0);
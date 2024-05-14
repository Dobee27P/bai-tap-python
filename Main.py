from fastapi import FastAPI
import pyodbc

app = FastAPI()

def get_db_connection():
    conn = pyodbc.connect(
        'DRIVER={ODBC Driver 17 for SQL Server};'
        'SERVER=desktop-p86b7r4\\sqlexpress;'
        'DATABASE=WeatherMonitoring;'
        'UID=sa;'
        'PWD=123;'
    )
    return conn

@app.get("/weather")
def read_weather():
    conn = get_db_connection()
    cursor = conn.cursor()
    cursor.execute("SELECT * FROM WeatherData")
    rows = cursor.fetchall()
    conn.close()

    weather_data = []
    for row in rows:
        weather_data.append({
            "timestamp": row.timestamp,
            "temperature": row.temperature,
            "humidity": row.humidity,
            "pressure": row.pressure,
            "wind_speed": row.wind_speed
        })
    
    return weather_data

if __name__ == "__main__":
    import uvicorn
    uvicorn.run(app, host="127.0.0.1", port=8000)

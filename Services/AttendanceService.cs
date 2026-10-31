namespace EventEase.Services;

public class AttendanceService
{
    private readonly Dictionary<int, HashSet<string>> _attendance = new();

    public bool MarkAttendance(int eventId, string email)
    {
        if (!_attendance.ContainsKey(eventId))
            _attendance[eventId] = new HashSet<string>();

        return _attendance[eventId].Add(email);
    }

    public bool IsAttending(int eventId, string email)
    {
        return _attendance.ContainsKey(eventId) && _attendance[eventId].Contains(email);
    }

    public int GetAttendanceCount(int eventId)
    {
        return _attendance.ContainsKey(eventId) ? _attendance[eventId].Count : 0;
    }
}
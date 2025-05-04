using Microsoft.AspNetCore.Mvc;

public class ReservationController : Controller
{
    [HttpPost]
    public IActionResult Select(int trainId)
    {
        // trainId をもとに仮のデータを渡すか、ダミー表示する
        ViewBag.TrainId = trainId;
        return View();
    }


    [HttpPost]
    public IActionResult Confirm(int trainId)
    {
        // 通常はtrainIdを元にDBなどから予約内容を取得
        // 今回は固定のダミーデータを表示
        return View();
    }
}

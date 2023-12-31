// Decompiled with JetBrains decompiler
// Type: ProjectM.ShowAi
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ShowAi
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DrawUnsmoothedPath;
    private static readonly System.IntPtr NativeFieldInfoPtr_DrawCurrentTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_DrawPath;
    private static readonly System.IntPtr NativeFieldInfoPtr_DrawPathfindingPivot;
    private static readonly System.IntPtr NativeFieldInfoPtr_DrawAggro;
    private static readonly System.IntPtr NativeFieldInfoPtr_DrawAlert;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrintAggroBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrintAlertBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_DrawState;
    private static readonly System.IntPtr NativeFieldInfoPtr_DrawDistances;
    private static readonly System.IntPtr NativeFieldInfoPtr_DrawPatrols;
    private static readonly System.IntPtr NativeFieldInfoPtr_DrawPrioritization;
    [FieldOffset(0)]
    public bool DrawUnsmoothedPath;
    [FieldOffset(1)]
    public bool DrawCurrentTarget;
    [FieldOffset(2)]
    public bool DrawPath;
    [FieldOffset(3)]
    public bool DrawPathfindingPivot;
    [FieldOffset(4)]
    public bool DrawAggro;
    [FieldOffset(5)]
    public bool DrawAlert;
    [FieldOffset(6)]
    public bool PrintAggroBuffer;
    [FieldOffset(7)]
    public bool PrintAlertBuffer;
    [FieldOffset(8)]
    public bool DrawState;
    [FieldOffset(9)]
    public bool DrawDistances;
    [FieldOffset(10)]
    public bool DrawPatrols;
    [FieldOffset(11)]
    public bool DrawPrioritization;

    static ShowAi()
    {
      Il2CppClassPointerStore<ShowAi>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ShowAi));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowAi>.NativeClassPtr);
      ShowAi.NativeFieldInfoPtr_DrawUnsmoothedPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAi>.NativeClassPtr, nameof (DrawUnsmoothedPath));
      ShowAi.NativeFieldInfoPtr_DrawCurrentTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAi>.NativeClassPtr, nameof (DrawCurrentTarget));
      ShowAi.NativeFieldInfoPtr_DrawPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAi>.NativeClassPtr, nameof (DrawPath));
      ShowAi.NativeFieldInfoPtr_DrawPathfindingPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAi>.NativeClassPtr, nameof (DrawPathfindingPivot));
      ShowAi.NativeFieldInfoPtr_DrawAggro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAi>.NativeClassPtr, nameof (DrawAggro));
      ShowAi.NativeFieldInfoPtr_DrawAlert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAi>.NativeClassPtr, nameof (DrawAlert));
      ShowAi.NativeFieldInfoPtr_PrintAggroBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAi>.NativeClassPtr, nameof (PrintAggroBuffer));
      ShowAi.NativeFieldInfoPtr_PrintAlertBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAi>.NativeClassPtr, nameof (PrintAlertBuffer));
      ShowAi.NativeFieldInfoPtr_DrawState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAi>.NativeClassPtr, nameof (DrawState));
      ShowAi.NativeFieldInfoPtr_DrawDistances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAi>.NativeClassPtr, nameof (DrawDistances));
      ShowAi.NativeFieldInfoPtr_DrawPatrols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAi>.NativeClassPtr, nameof (DrawPatrols));
      ShowAi.NativeFieldInfoPtr_DrawPrioritization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAi>.NativeClassPtr, nameof (DrawPrioritization));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowAi>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

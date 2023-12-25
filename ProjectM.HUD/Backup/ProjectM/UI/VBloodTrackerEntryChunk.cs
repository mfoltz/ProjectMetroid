// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.VBloodTrackerEntryChunk
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct VBloodTrackerEntryChunk
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitState;
    private static readonly System.IntPtr NativeFieldInfoPtr_Level;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_Act;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Length;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsNewAct;
    [FieldOffset(0)]
    public VBloodUnitTrackingState UnitState;
    [FieldOffset(4)]
    public int Level;
    [FieldOffset(8)]
    public int PlayerLevel;
    [FieldOffset(12)]
    public int Act;
    [FieldOffset(16)]
    public int StartIndex;
    [FieldOffset(20)]
    public int Length;
    [FieldOffset(24)]
    public bool IsNewAct;

    static VBloodTrackerEntryChunk()
    {
      Il2CppClassPointerStore<VBloodTrackerEntryChunk>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (VBloodTrackerEntryChunk));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VBloodTrackerEntryChunk>.NativeClassPtr);
      VBloodTrackerEntryChunk.NativeFieldInfoPtr_UnitState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackerEntryChunk>.NativeClassPtr, nameof (UnitState));
      VBloodTrackerEntryChunk.NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackerEntryChunk>.NativeClassPtr, nameof (Level));
      VBloodTrackerEntryChunk.NativeFieldInfoPtr_PlayerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackerEntryChunk>.NativeClassPtr, nameof (PlayerLevel));
      VBloodTrackerEntryChunk.NativeFieldInfoPtr_Act = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackerEntryChunk>.NativeClassPtr, nameof (Act));
      VBloodTrackerEntryChunk.NativeFieldInfoPtr_StartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackerEntryChunk>.NativeClassPtr, nameof (StartIndex));
      VBloodTrackerEntryChunk.NativeFieldInfoPtr_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackerEntryChunk>.NativeClassPtr, nameof (Length));
      VBloodTrackerEntryChunk.NativeFieldInfoPtr_IsNewAct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackerEntryChunk>.NativeClassPtr, nameof (IsNewAct));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VBloodTrackerEntryChunk>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

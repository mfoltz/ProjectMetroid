// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Buff_VisionRangeModification_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_Buff_VisionRangeModification_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_VisionModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_VisionCurve;
    private static readonly System.IntPtr NativeFieldInfoPtr_OldRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinRange;
    [FieldOffset(0)]
    public ModificationId VisionModificationId;
    [FieldOffset(4)]
    public CurveReference VisionCurve;
    [FieldOffset(12)]
    public float OldRange;
    [FieldOffset(16)]
    public float MinRange;

    static Script_Buff_VisionRangeModification_DataServer()
    {
      Il2CppClassPointerStore<Script_Buff_VisionRangeModification_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Buff_VisionRangeModification_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Buff_VisionRangeModification_DataServer>.NativeClassPtr);
      Script_Buff_VisionRangeModification_DataServer.NativeFieldInfoPtr_VisionModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_VisionRangeModification_DataServer>.NativeClassPtr, nameof (VisionModificationId));
      Script_Buff_VisionRangeModification_DataServer.NativeFieldInfoPtr_VisionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_VisionRangeModification_DataServer>.NativeClassPtr, nameof (VisionCurve));
      Script_Buff_VisionRangeModification_DataServer.NativeFieldInfoPtr_OldRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_VisionRangeModification_DataServer>.NativeClassPtr, nameof (OldRange));
      Script_Buff_VisionRangeModification_DataServer.NativeFieldInfoPtr_MinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_VisionRangeModification_DataServer>.NativeClassPtr, nameof (MinRange));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_Buff_VisionRangeModification_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

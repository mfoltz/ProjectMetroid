// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_SetFlyingHeightVision_Buff_DataShared
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_SetFlyingHeightVision_Buff_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_VisionModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Delay;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffActive;
    [FieldOffset(0)]
    public ModificationId VisionModificationId;
    [FieldOffset(4)]
    public float Delay;
    [FieldOffset(8)]
    public bool BuffActive;

    static Script_SetFlyingHeightVision_Buff_DataShared()
    {
      Il2CppClassPointerStore<Script_SetFlyingHeightVision_Buff_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_SetFlyingHeightVision_Buff_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_SetFlyingHeightVision_Buff_DataShared>.NativeClassPtr);
      Script_SetFlyingHeightVision_Buff_DataShared.NativeFieldInfoPtr_VisionModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SetFlyingHeightVision_Buff_DataShared>.NativeClassPtr, nameof (VisionModificationId));
      Script_SetFlyingHeightVision_Buff_DataShared.NativeFieldInfoPtr_Delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SetFlyingHeightVision_Buff_DataShared>.NativeClassPtr, nameof (Delay));
      Script_SetFlyingHeightVision_Buff_DataShared.NativeFieldInfoPtr_BuffActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SetFlyingHeightVision_Buff_DataShared>.NativeClassPtr, nameof (BuffActive));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_SetFlyingHeightVision_Buff_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

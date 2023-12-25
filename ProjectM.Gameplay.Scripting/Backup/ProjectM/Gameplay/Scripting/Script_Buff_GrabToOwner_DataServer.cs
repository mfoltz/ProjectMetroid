// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Buff_GrabToOwner_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_Buff_GrabToOwner_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PositionOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_Offset;
    [FieldOffset(0)]
    public float3 PositionOffset;
    [FieldOffset(12)]
    public float Offset;

    static Script_Buff_GrabToOwner_DataServer()
    {
      Il2CppClassPointerStore<Script_Buff_GrabToOwner_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Buff_GrabToOwner_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Buff_GrabToOwner_DataServer>.NativeClassPtr);
      Script_Buff_GrabToOwner_DataServer.NativeFieldInfoPtr_PositionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_GrabToOwner_DataServer>.NativeClassPtr, nameof (PositionOffset));
      Script_Buff_GrabToOwner_DataServer.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_GrabToOwner_DataServer>.NativeClassPtr, nameof (Offset));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_Buff_GrabToOwner_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

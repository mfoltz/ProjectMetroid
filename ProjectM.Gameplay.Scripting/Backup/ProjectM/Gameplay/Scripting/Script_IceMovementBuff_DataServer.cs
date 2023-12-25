// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_IceMovementBuff_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_IceMovementBuff_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Acceleration;
    private static readonly System.IntPtr NativeFieldInfoPtr_Friction;
    private static readonly System.IntPtr NativeFieldInfoPtr_AccerationModId;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrictionModId;
    [FieldOffset(0)]
    public float Acceleration;
    [FieldOffset(4)]
    public float Friction;
    [FieldOffset(8)]
    public ModificationId AccerationModId;
    [FieldOffset(12)]
    public ModificationId FrictionModId;

    static Script_IceMovementBuff_DataServer()
    {
      Il2CppClassPointerStore<Script_IceMovementBuff_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_IceMovementBuff_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_IceMovementBuff_DataServer>.NativeClassPtr);
      Script_IceMovementBuff_DataServer.NativeFieldInfoPtr_Acceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_IceMovementBuff_DataServer>.NativeClassPtr, nameof (Acceleration));
      Script_IceMovementBuff_DataServer.NativeFieldInfoPtr_Friction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_IceMovementBuff_DataServer>.NativeClassPtr, nameof (Friction));
      Script_IceMovementBuff_DataServer.NativeFieldInfoPtr_AccerationModId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_IceMovementBuff_DataServer>.NativeClassPtr, nameof (AccerationModId));
      Script_IceMovementBuff_DataServer.NativeFieldInfoPtr_FrictionModId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_IceMovementBuff_DataServer>.NativeClassPtr, nameof (FrictionModId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_IceMovementBuff_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

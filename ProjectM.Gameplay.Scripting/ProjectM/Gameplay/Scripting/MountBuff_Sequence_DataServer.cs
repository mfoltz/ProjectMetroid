// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.MountBuff_Sequence_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MountBuff_Sequence_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreviousWeaponEntity;
    [FieldOffset(0)]
    public SequenceGUID SequenceGuid;
    [FieldOffset(4)]
    public SequenceState SequenceState;
    [FieldOffset(12)]
    public Entity PreviousWeaponEntity;

    static MountBuff_Sequence_DataServer()
    {
      Il2CppClassPointerStore<MountBuff_Sequence_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (MountBuff_Sequence_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MountBuff_Sequence_DataServer>.NativeClassPtr);
      MountBuff_Sequence_DataServer.NativeFieldInfoPtr_SequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountBuff_Sequence_DataServer>.NativeClassPtr, nameof (SequenceGuid));
      MountBuff_Sequence_DataServer.NativeFieldInfoPtr_SequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountBuff_Sequence_DataServer>.NativeClassPtr, nameof (SequenceState));
      MountBuff_Sequence_DataServer.NativeFieldInfoPtr_PreviousWeaponEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountBuff_Sequence_DataServer>.NativeClassPtr, nameof (PreviousWeaponEntity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MountBuff_Sequence_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

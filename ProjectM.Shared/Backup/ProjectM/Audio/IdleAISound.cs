// Decompiled with JetBrains decompiler
// Type: ProjectM.Audio.IdleAISound
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Audio
{
  [StructLayout(LayoutKind.Explicit)]
  public struct IdleAISound
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LastSetSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsAggro;
    private static readonly System.IntPtr NativeFieldInfoPtr_Active;
    private static readonly System.IntPtr NativeFieldInfoPtr_Deleted;
    [FieldOffset(0)]
    public float LastSetSpeed;
    [FieldOffset(4)]
    public float MaxSpeed;
    [FieldOffset(8)]
    public bool IsAggro;
    [FieldOffset(9)]
    public bool Active;
    [FieldOffset(10)]
    public bool Deleted;

    static IdleAISound()
    {
      Il2CppClassPointerStore<IdleAISound>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Audio", nameof (IdleAISound));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdleAISound>.NativeClassPtr);
      IdleAISound.NativeFieldInfoPtr_LastSetSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISound>.NativeClassPtr, nameof (LastSetSpeed));
      IdleAISound.NativeFieldInfoPtr_MaxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISound>.NativeClassPtr, nameof (MaxSpeed));
      IdleAISound.NativeFieldInfoPtr_IsAggro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISound>.NativeClassPtr, nameof (IsAggro));
      IdleAISound.NativeFieldInfoPtr_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISound>.NativeClassPtr, nameof (Active));
      IdleAISound.NativeFieldInfoPtr_Deleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISound>.NativeClassPtr, nameof (Deleted));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IdleAISound>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

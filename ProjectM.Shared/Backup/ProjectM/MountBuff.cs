// Decompiled with JetBrains decompiler
// Type: ProjectM.MountBuff
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MountBuff
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AllowJumpFromCliffsModId;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxAngleModId;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffableStateFlagsModification;
    private static readonly System.IntPtr NativeFieldInfoPtr_FeedProgressTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FeedTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsFed;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_Health;
    [FieldOffset(0)]
    public ModificationId AllowJumpFromCliffsModId;
    [FieldOffset(4)]
    public ModificationId MaxAngleModId;
    [FieldOffset(8)]
    public ModificationId BuffableStateFlagsModification;
    [FieldOffset(12)]
    public float FeedProgressTime;
    [FieldOffset(16)]
    public float FeedTime;
    [FieldOffset(20)]
    public bool IsFed;
    [FieldOffset(22)]
    public FixedString64 Name;
    [FieldOffset(88)]
    public float MaxHealth;
    [FieldOffset(92)]
    public float Health;

    static MountBuff()
    {
      Il2CppClassPointerStore<MountBuff>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (MountBuff));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MountBuff>.NativeClassPtr);
      MountBuff.NativeFieldInfoPtr_AllowJumpFromCliffsModId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountBuff>.NativeClassPtr, nameof (AllowJumpFromCliffsModId));
      MountBuff.NativeFieldInfoPtr_MaxAngleModId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountBuff>.NativeClassPtr, nameof (MaxAngleModId));
      MountBuff.NativeFieldInfoPtr_BuffableStateFlagsModification = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountBuff>.NativeClassPtr, nameof (BuffableStateFlagsModification));
      MountBuff.NativeFieldInfoPtr_FeedProgressTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountBuff>.NativeClassPtr, nameof (FeedProgressTime));
      MountBuff.NativeFieldInfoPtr_FeedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountBuff>.NativeClassPtr, nameof (FeedTime));
      MountBuff.NativeFieldInfoPtr_IsFed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountBuff>.NativeClassPtr, nameof (IsFed));
      MountBuff.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountBuff>.NativeClassPtr, nameof (Name));
      MountBuff.NativeFieldInfoPtr_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountBuff>.NativeClassPtr, nameof (MaxHealth));
      MountBuff.NativeFieldInfoPtr_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountBuff>.NativeClassPtr, nameof (Health));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MountBuff>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

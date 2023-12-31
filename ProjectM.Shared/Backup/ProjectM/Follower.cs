// Decompiled with JetBrains decompiler
// Type: ProjectM.Follower
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Follower
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Followed;
    private static readonly System.IntPtr NativeFieldInfoPtr_Offset;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastOffsetUpdateTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModeModifiable;
    private static readonly System.IntPtr NativeFieldInfoPtr_Stationary;
    private static readonly System.IntPtr NativeFieldInfoPtr_InheritRotationWhenStationary;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Mode_Public_get_FollowMode_0;
    [FieldOffset(0)]
    public ModifiableEntity Followed;
    [FieldOffset(12)]
    public float2 Offset;
    [FieldOffset(24)]
    public double LastOffsetUpdateTime;
    [FieldOffset(32)]
    public ModifiableInt ModeModifiable;
    [FieldOffset(40)]
    public ModifiableBool Stationary;
    [FieldOffset(44)]
    public bool InheritRotationWhenStationary;

    public unsafe FollowMode Mode
    {
      [CallerCount(36), CachedScanResults(RefRangeStart = 29682, RefRangeEnd = 29718, XrefRangeStart = 29682, XrefRangeEnd = 29718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Follower.NativeMethodInfoPtr_get_Mode_Public_get_FollowMode_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(FollowMode*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static Follower()
    {
      Il2CppClassPointerStore<Follower>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Follower));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Follower>.NativeClassPtr);
      Follower.NativeFieldInfoPtr_Followed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Follower>.NativeClassPtr, nameof (Followed));
      Follower.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Follower>.NativeClassPtr, nameof (Offset));
      Follower.NativeFieldInfoPtr_LastOffsetUpdateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Follower>.NativeClassPtr, nameof (LastOffsetUpdateTime));
      Follower.NativeFieldInfoPtr_ModeModifiable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Follower>.NativeClassPtr, nameof (ModeModifiable));
      Follower.NativeFieldInfoPtr_Stationary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Follower>.NativeClassPtr, nameof (Stationary));
      Follower.NativeFieldInfoPtr_InheritRotationWhenStationary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Follower>.NativeClassPtr, nameof (InheritRotationWhenStationary));
      Follower.NativeMethodInfoPtr_get_Mode_Public_get_FollowMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Follower>.NativeClassPtr, 100663911);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Follower>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

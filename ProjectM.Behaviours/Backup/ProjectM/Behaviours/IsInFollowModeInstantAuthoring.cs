// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.IsInFollowModeInstantAuthoring
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Stunlock.Sequencer;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Behaviours
{
  public class IsInFollowModeInstantAuthoring : BehaviourTreeNodeAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_Mode;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FollowMode_0;
    private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1338538, RefRangeEnd = 1338541, XrefRangeStart = 1338534, XrefRangeEnd = 1338538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IsInFollowModeInstantAuthoring(FollowMode mode)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IsInFollowModeInstantAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &mode;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IsInFollowModeInstantAuthoring.NativeMethodInfoPtr__ctor_Public_Void_FollowMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1338541, XrefRangeEnd = 1338544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppStructArray<byte> Serialize(BlackboardBuilder blackboardBuilder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IsInFollowModeInstantAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr nativeObject = num;
      return nativeObject == IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(nativeObject);
    }

    public override unsafe BehaviourTreeNodeType NodeType
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IsInFollowModeInstantAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BehaviourTreeNodeType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static IsInFollowModeInstantAuthoring()
    {
      Il2CppClassPointerStore<IsInFollowModeInstantAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (IsInFollowModeInstantAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IsInFollowModeInstantAuthoring>.NativeClassPtr);
      IsInFollowModeInstantAuthoring.NativeFieldInfoPtr_Mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IsInFollowModeInstantAuthoring>.NativeClassPtr, nameof (Mode));
      IsInFollowModeInstantAuthoring.NativeMethodInfoPtr__ctor_Public_Void_FollowMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsInFollowModeInstantAuthoring>.NativeClassPtr, 100664750);
      IsInFollowModeInstantAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsInFollowModeInstantAuthoring>.NativeClassPtr, 100664751);
      IsInFollowModeInstantAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsInFollowModeInstantAuthoring>.NativeClassPtr, 100664752);
    }

    public IsInFollowModeInstantAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe FollowMode Mode
    {
      get
      {
        return *(FollowMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IsInFollowModeInstantAuthoring.NativeFieldInfoPtr_Mode));
      }
      [param: In] set
      {
        *(FollowMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IsInFollowModeInstantAuthoring.NativeFieldInfoPtr_Mode)) = value;
      }
    }
  }
}

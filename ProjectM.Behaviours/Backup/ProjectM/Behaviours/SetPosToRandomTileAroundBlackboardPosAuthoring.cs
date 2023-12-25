// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.SetPosToRandomTileAroundBlackboardPosAuthoring
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
  public class SetPosToRandomTileAroundBlackboardPosAuthoring : BehaviourTreeNodeAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_MinRadius;
    private static readonly IntPtr NativeFieldInfoPtr_MaxRadius;
    private static readonly IntPtr NativeFieldInfoPtr_InRegister;
    private static readonly IntPtr NativeFieldInfoPtr_OutRegister;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_String_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1339298, RefRangeEnd = 1339300, XrefRangeStart = 1339292, XrefRangeEnd = 1339298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SetPosToRandomTileAroundBlackboardPosAuthoring(
      float minRadius,
      float maxRadius,
      string inRegister,
      string outRegister)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetPosToRandomTileAroundBlackboardPosAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = (IntPtr) &minRadius;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &maxRadius;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(inRegister);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(outRegister);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetPosToRandomTileAroundBlackboardPosAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339300, XrefRangeEnd = 1339311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppStructArray<byte> Serialize(BlackboardBuilder blackboardBuilder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetPosToRandomTileAroundBlackboardPosAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetPosToRandomTileAroundBlackboardPosAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BehaviourTreeNodeType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static SetPosToRandomTileAroundBlackboardPosAuthoring()
    {
      Il2CppClassPointerStore<SetPosToRandomTileAroundBlackboardPosAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (SetPosToRandomTileAroundBlackboardPosAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetPosToRandomTileAroundBlackboardPosAuthoring>.NativeClassPtr);
      SetPosToRandomTileAroundBlackboardPosAuthoring.NativeFieldInfoPtr_MinRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPosToRandomTileAroundBlackboardPosAuthoring>.NativeClassPtr, nameof (MinRadius));
      SetPosToRandomTileAroundBlackboardPosAuthoring.NativeFieldInfoPtr_MaxRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPosToRandomTileAroundBlackboardPosAuthoring>.NativeClassPtr, nameof (MaxRadius));
      SetPosToRandomTileAroundBlackboardPosAuthoring.NativeFieldInfoPtr_InRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPosToRandomTileAroundBlackboardPosAuthoring>.NativeClassPtr, nameof (InRegister));
      SetPosToRandomTileAroundBlackboardPosAuthoring.NativeFieldInfoPtr_OutRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPosToRandomTileAroundBlackboardPosAuthoring>.NativeClassPtr, nameof (OutRegister));
      SetPosToRandomTileAroundBlackboardPosAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPosToRandomTileAroundBlackboardPosAuthoring>.NativeClassPtr, 100664912);
      SetPosToRandomTileAroundBlackboardPosAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPosToRandomTileAroundBlackboardPosAuthoring>.NativeClassPtr, 100664913);
      SetPosToRandomTileAroundBlackboardPosAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPosToRandomTileAroundBlackboardPosAuthoring>.NativeClassPtr, 100664914);
    }

    public SetPosToRandomTileAroundBlackboardPosAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float MinRadius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetPosToRandomTileAroundBlackboardPosAuthoring.NativeFieldInfoPtr_MinRadius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetPosToRandomTileAroundBlackboardPosAuthoring.NativeFieldInfoPtr_MinRadius)) = value;
      }
    }

    public unsafe float MaxRadius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetPosToRandomTileAroundBlackboardPosAuthoring.NativeFieldInfoPtr_MaxRadius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetPosToRandomTileAroundBlackboardPosAuthoring.NativeFieldInfoPtr_MaxRadius)) = value;
      }
    }

    public unsafe string InRegister
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetPosToRandomTileAroundBlackboardPosAuthoring.NativeFieldInfoPtr_InRegister)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SetPosToRandomTileAroundBlackboardPosAuthoring.NativeFieldInfoPtr_InRegister), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string OutRegister
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetPosToRandomTileAroundBlackboardPosAuthoring.NativeFieldInfoPtr_OutRegister)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SetPosToRandomTileAroundBlackboardPosAuthoring.NativeFieldInfoPtr_OutRegister), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}

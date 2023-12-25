// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.TrySetEntityToClosestResourceNodeAuthoring
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
  public class TrySetEntityToClosestResourceNodeAuthoring : BehaviourTreeNodeAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_Range;
    private static readonly IntPtr NativeFieldInfoPtr_Register;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1339685, RefRangeEnd = 1339686, XrefRangeStart = 1339680, XrefRangeEnd = 1339685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TrySetEntityToClosestResourceNodeAuthoring(float range, string register)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrySetEntityToClosestResourceNodeAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &range;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(register);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrySetEntityToClosestResourceNodeAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339686, XrefRangeEnd = 1339695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppStructArray<byte> Serialize(BlackboardBuilder blackboardBuilder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TrySetEntityToClosestResourceNodeAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TrySetEntityToClosestResourceNodeAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BehaviourTreeNodeType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static TrySetEntityToClosestResourceNodeAuthoring()
    {
      Il2CppClassPointerStore<TrySetEntityToClosestResourceNodeAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (TrySetEntityToClosestResourceNodeAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrySetEntityToClosestResourceNodeAuthoring>.NativeClassPtr);
      TrySetEntityToClosestResourceNodeAuthoring.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrySetEntityToClosestResourceNodeAuthoring>.NativeClassPtr, nameof (Range));
      TrySetEntityToClosestResourceNodeAuthoring.NativeFieldInfoPtr_Register = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrySetEntityToClosestResourceNodeAuthoring>.NativeClassPtr, nameof (Register));
      TrySetEntityToClosestResourceNodeAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrySetEntityToClosestResourceNodeAuthoring>.NativeClassPtr, 100664977);
      TrySetEntityToClosestResourceNodeAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrySetEntityToClosestResourceNodeAuthoring>.NativeClassPtr, 100664978);
      TrySetEntityToClosestResourceNodeAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrySetEntityToClosestResourceNodeAuthoring>.NativeClassPtr, 100664979);
    }

    public TrySetEntityToClosestResourceNodeAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float Range
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrySetEntityToClosestResourceNodeAuthoring.NativeFieldInfoPtr_Range));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrySetEntityToClosestResourceNodeAuthoring.NativeFieldInfoPtr_Range)) = value;
      }
    }

    public unsafe string Register
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrySetEntityToClosestResourceNodeAuthoring.NativeFieldInfoPtr_Register)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrySetEntityToClosestResourceNodeAuthoring.NativeFieldInfoPtr_Register), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}

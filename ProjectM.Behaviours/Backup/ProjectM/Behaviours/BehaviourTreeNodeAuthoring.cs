// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.BehaviourTreeNodeAuthoring
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Stunlock.Sequencer;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Behaviours
{
  public class BehaviourTreeNodeAuthoring : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Children;
    private static readonly System.IntPtr NativeFieldInfoPtr__ReferencedBlackboardFields;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ChildCount_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_BehaviourTreeNodeAuthoring_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddChild_Public_Void_BehaviourTreeNodeAuthoring_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_UInt16_BehaviourTreeBlobBuilder_BlackboardBuilder_UInt16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterReferencedField_Protected_Void_SharedField_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterReferencedField_Protected_Void_OptionalSharedField_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterReferencedField_Protected_Void_PrivateField_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_New_Il2CppStructArray_1_Byte_BlackboardBuilder_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_NodeType_Public_Abstract_Virtual_New_get_BehaviourTreeNodeType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_NewGuid_Protected_String_0;

    public unsafe int ChildCount
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336256, XrefRangeEnd = 1336257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeNodeAuthoring.NativeMethodInfoPtr_get_ChildCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(303)]
    [CachedScanResults(RefRangeStart = 1336276, RefRangeEnd = 1336579, XrefRangeStart = 1336257, XrefRangeEnd = 1336276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeNodeAuthoring(
      [Optional] Il2CppReferenceArray<BehaviourTreeNodeAuthoring> children)
    {
      if (children == null)
        children = new Il2CppReferenceArray<BehaviourTreeNodeAuthoring>(0L);
      // ISSUE: explicit constructor call
      this.\u002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BehaviourTreeNodeAuthoring>.NativeClassPtr));
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) children);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BehaviourTreeNodeAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336579, XrefRangeEnd = 1336583, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddChild(BehaviourTreeNodeAuthoring child)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) child);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BehaviourTreeNodeAuthoring.NativeMethodInfoPtr_AddChild_Public_Void_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1336640, RefRangeEnd = 1336642, XrefRangeStart = 1336583, XrefRangeEnd = 1336640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ushort Convert(
      BehaviourTreeBlobBuilder builder,
      BlackboardBuilder blackboardBuilder,
      ushort parentIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) builder);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &parentIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeNodeAuthoring.NativeMethodInfoPtr_Convert_Public_UInt16_BehaviourTreeBlobBuilder_BlackboardBuilder_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ushort*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1336646, RefRangeEnd = 1336651, XrefRangeStart = 1336642, XrefRangeEnd = 1336646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RegisterReferencedField<T>(SharedField<T> field)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &field;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BehaviourTreeNodeAuthoring.MethodInfoStoreGeneric_RegisterReferencedField_Protected_Void_SharedField_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1336654, RefRangeEnd = 1336655, XrefRangeStart = 1336651, XrefRangeEnd = 1336654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RegisterReferencedField<T>(OptionalSharedField<T> field)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &field;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BehaviourTreeNodeAuthoring.MethodInfoStoreGeneric_RegisterReferencedField_Protected_Void_OptionalSharedField_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1336659, RefRangeEnd = 1336661, XrefRangeStart = 1336655, XrefRangeEnd = 1336659, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RegisterReferencedField<T>(PrivateField<T> field)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &field;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BehaviourTreeNodeAuthoring.MethodInfoStoreGeneric_RegisterReferencedField_Protected_Void_PrivateField_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336661, XrefRangeEnd = 1336664, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppStructArray<byte> Serialize(BlackboardBuilder blackboardBuilder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BehaviourTreeNodeAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_New_Il2CppStructArray_1_Byte_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(nativeObject);
    }

    public virtual unsafe BehaviourTreeNodeType NodeType
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BehaviourTreeNodeAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Abstract_Virtual_New_get_BehaviourTreeNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BehaviourTreeNodeType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(21)]
    [CachedScanResults(RefRangeStart = 1336669, RefRangeEnd = 1336690, XrefRangeStart = 1336664, XrefRangeEnd = 1336669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string NewGuid()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeNodeAuthoring.NativeMethodInfoPtr_NewGuid_Protected_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    public BehaviourTreeNodeAuthoring(params BehaviourTreeNodeAuthoring[] children)
      : this(new Il2CppReferenceArray<BehaviourTreeNodeAuthoring>(children))
    {
    }

    static BehaviourTreeNodeAuthoring()
    {
      Il2CppClassPointerStore<BehaviourTreeNodeAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (BehaviourTreeNodeAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeNodeAuthoring>.NativeClassPtr);
      BehaviourTreeNodeAuthoring.NativeFieldInfoPtr__Children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeNodeAuthoring>.NativeClassPtr, nameof (_Children));
      BehaviourTreeNodeAuthoring.NativeFieldInfoPtr__ReferencedBlackboardFields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeNodeAuthoring>.NativeClassPtr, nameof (_ReferencedBlackboardFields));
      BehaviourTreeNodeAuthoring.NativeMethodInfoPtr_get_ChildCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeNodeAuthoring>.NativeClassPtr, 100664440);
      BehaviourTreeNodeAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeNodeAuthoring>.NativeClassPtr, 100664441);
      BehaviourTreeNodeAuthoring.NativeMethodInfoPtr_AddChild_Public_Void_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeNodeAuthoring>.NativeClassPtr, 100664442);
      BehaviourTreeNodeAuthoring.NativeMethodInfoPtr_Convert_Public_UInt16_BehaviourTreeBlobBuilder_BlackboardBuilder_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeNodeAuthoring>.NativeClassPtr, 100664443);
      BehaviourTreeNodeAuthoring.NativeMethodInfoPtr_RegisterReferencedField_Protected_Void_SharedField_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeNodeAuthoring>.NativeClassPtr, 100664444);
      BehaviourTreeNodeAuthoring.NativeMethodInfoPtr_RegisterReferencedField_Protected_Void_OptionalSharedField_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeNodeAuthoring>.NativeClassPtr, 100664445);
      BehaviourTreeNodeAuthoring.NativeMethodInfoPtr_RegisterReferencedField_Protected_Void_PrivateField_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeNodeAuthoring>.NativeClassPtr, 100664446);
      BehaviourTreeNodeAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_New_Il2CppStructArray_1_Byte_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeNodeAuthoring>.NativeClassPtr, 100664447);
      BehaviourTreeNodeAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Abstract_Virtual_New_get_BehaviourTreeNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeNodeAuthoring>.NativeClassPtr, 100664448);
      BehaviourTreeNodeAuthoring.NativeMethodInfoPtr_NewGuid_Protected_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeNodeAuthoring>.NativeClassPtr, 100664449);
    }

    public BehaviourTreeNodeAuthoring(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<BehaviourTreeNodeAuthoring> _Children
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeNodeAuthoring.NativeFieldInfoPtr__Children));
        return pointer == System.IntPtr.Zero ? (List<BehaviourTreeNodeAuthoring>) null : new List<BehaviourTreeNodeAuthoring>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeNodeAuthoring.NativeFieldInfoPtr__Children), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<int> _ReferencedBlackboardFields
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeNodeAuthoring.NativeFieldInfoPtr__ReferencedBlackboardFields));
        return pointer == System.IntPtr.Zero ? (List<int>) null : new List<int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeNodeAuthoring.NativeFieldInfoPtr__ReferencedBlackboardFields), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    private sealed class MethodInfoStoreGeneric_RegisterReferencedField_Protected_Void_SharedField_1_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(BehaviourTreeNodeAuthoring.NativeMethodInfoPtr_RegisterReferencedField_Protected_Void_SharedField_1_T_0, Il2CppClassPointerStore<BehaviourTreeNodeAuthoring>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_RegisterReferencedField_Protected_Void_OptionalSharedField_1_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(BehaviourTreeNodeAuthoring.NativeMethodInfoPtr_RegisterReferencedField_Protected_Void_OptionalSharedField_1_T_0, Il2CppClassPointerStore<BehaviourTreeNodeAuthoring>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_RegisterReferencedField_Protected_Void_PrivateField_1_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(BehaviourTreeNodeAuthoring.NativeMethodInfoPtr_RegisterReferencedField_Protected_Void_PrivateField_1_T_0, Il2CppClassPointerStore<BehaviourTreeNodeAuthoring>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}

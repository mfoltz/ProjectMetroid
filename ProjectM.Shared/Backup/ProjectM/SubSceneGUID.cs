// Decompiled with JetBrains decompiler
// Type: ProjectM.SubSceneGUID
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SubSceneGUID
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_Empty;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromStringGUID_Public_Static_SubSceneGUID_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Hash128_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SubSceneGUID_SubSceneGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SubSceneGUID_SubSceneGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SubSceneGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    [FieldOffset(0)]
    public readonly Hash128 GUID;

    public unsafe bool IsValid
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 750350, RefRangeEnd = 750351, XrefRangeStart = 750349, XrefRangeEnd = 750350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SubSceneGUID.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 750352, RefRangeEnd = 750353, XrefRangeStart = 750351, XrefRangeEnd = 750352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe SubSceneGUID FromStringGUID(string guid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(guid);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SubSceneGUID.NativeMethodInfoPtr_FromStringGUID_Public_Static_SubSceneGUID_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SubSceneGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(103)]
    [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SubSceneGUID(Hash128 guid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &guid;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SubSceneGUID.NativeMethodInfoPtr__ctor_Public_Void_Hash128_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SubSceneGUID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750353, XrefRangeEnd = 750354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator ==(SubSceneGUID a, SubSceneGUID b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SubSceneGUID.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SubSceneGUID_SubSceneGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 750355, RefRangeEnd = 750356, XrefRangeStart = 750354, XrefRangeEnd = 750355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator !=(SubSceneGUID a, SubSceneGUID b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SubSceneGUID.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SubSceneGUID_SubSceneGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750356, XrefRangeEnd = 750360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SubSceneGUID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(SubSceneGUID other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SubSceneGUID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SubSceneGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 750361, RefRangeEnd = 750362, XrefRangeStart = 750360, XrefRangeEnd = 750361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SubSceneGUID.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static SubSceneGUID()
    {
      Il2CppClassPointerStore<SubSceneGUID>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SubSceneGUID));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubSceneGUID>.NativeClassPtr);
      SubSceneGUID.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubSceneGUID>.NativeClassPtr, nameof (GUID));
      SubSceneGUID.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubSceneGUID>.NativeClassPtr, nameof (Empty));
      SubSceneGUID.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubSceneGUID>.NativeClassPtr, 100666053);
      SubSceneGUID.NativeMethodInfoPtr_FromStringGUID_Public_Static_SubSceneGUID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubSceneGUID>.NativeClassPtr, 100666054);
      SubSceneGUID.NativeMethodInfoPtr__ctor_Public_Void_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubSceneGUID>.NativeClassPtr, 100666055);
      SubSceneGUID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubSceneGUID>.NativeClassPtr, 100666056);
      SubSceneGUID.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SubSceneGUID_SubSceneGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubSceneGUID>.NativeClassPtr, 100666057);
      SubSceneGUID.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SubSceneGUID_SubSceneGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubSceneGUID>.NativeClassPtr, 100666058);
      SubSceneGUID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubSceneGUID>.NativeClassPtr, 100666059);
      SubSceneGUID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SubSceneGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubSceneGUID>.NativeClassPtr, 100666060);
      SubSceneGUID.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubSceneGUID>.NativeClassPtr, 100666061);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SubSceneGUID>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe SubSceneGUID Empty
    {
      get
      {
        SubSceneGUID empty;
        IL2CPP.il2cpp_field_static_get_value(SubSceneGUID.NativeFieldInfoPtr_Empty, (void*) &empty);
        return empty;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SubSceneGUID.NativeFieldInfoPtr_Empty, (void*) &value);
      }
    }
  }
}

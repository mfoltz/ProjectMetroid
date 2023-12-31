// Decompiled with JetBrains decompiler
// Type: ProjectM.PrefabLookupKey
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public sealed class PrefabLookupKey : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentType;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_PrefabLookupKey_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PrefabLookupKey_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751249, XrefRangeEnd = 751254, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PrefabLookupKey Create<T>(PrefabGUID prefabGUID)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &prefabGUID;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PrefabLookupKey.MethodInfoStoreGeneric_Create_Public_Static_PrefabLookupKey_PrefabGUID_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new PrefabLookupKey(pointer);
    }

    [CallerCount(0)]
    public override unsafe int GetHashCode()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabLookupKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751254, XrefRangeEnd = 751257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool Equals(Il2CppSystem.Object obj)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabLookupKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751257, XrefRangeEnd = 751259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(PrefabLookupKey other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other));
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabLookupKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PrefabLookupKey_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static PrefabLookupKey()
    {
      Il2CppClassPointerStore<PrefabLookupKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (PrefabLookupKey));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabLookupKey>.NativeClassPtr);
      PrefabLookupKey.NativeFieldInfoPtr_PrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabLookupKey>.NativeClassPtr, nameof (PrefabGUID));
      PrefabLookupKey.NativeFieldInfoPtr_ComponentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabLookupKey>.NativeClassPtr, nameof (ComponentType));
      PrefabLookupKey.NativeMethodInfoPtr_Create_Public_Static_PrefabLookupKey_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLookupKey>.NativeClassPtr, 100666158);
      PrefabLookupKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLookupKey>.NativeClassPtr, 100666159);
      PrefabLookupKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLookupKey>.NativeClassPtr, 100666160);
      PrefabLookupKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PrefabLookupKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLookupKey>.NativeClassPtr, 100666161);
    }

    public PrefabLookupKey(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public PrefabLookupKey()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PrefabLookupKey>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabLookupKey>.NativeClassPtr, data));
    }

    public unsafe PrefabGUID PrefabGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabLookupKey.NativeFieldInfoPtr_PrefabGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabLookupKey.NativeFieldInfoPtr_PrefabGUID)) = value;
      }
    }

    public unsafe Il2CppSystem.Type ComponentType
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabLookupKey.NativeFieldInfoPtr_ComponentType));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Type) null : new Il2CppSystem.Type(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrefabLookupKey.NativeFieldInfoPtr_ComponentType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    private sealed class MethodInfoStoreGeneric_Create_Public_Static_PrefabLookupKey_PrefabGUID_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PrefabLookupKey.NativeMethodInfoPtr_Create_Public_Static_PrefabLookupKey_PrefabGUID_0, Il2CppClassPointerStore<PrefabLookupKey>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}

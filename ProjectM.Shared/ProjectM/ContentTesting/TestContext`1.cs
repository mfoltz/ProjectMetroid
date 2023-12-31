// Decompiled with JetBrains decompiler
// Type: ProjectM.ContentTesting.TestContext`1
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.ContentTesting
{
  public sealed class TestContext<T> : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TestSessionId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_AssetPath;
    private static readonly System.IntPtr NativeFieldInfoPtr_RootAssetObject;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsAbstractAsset;
    private static readonly System.IntPtr NativeFieldInfoPtr_Labels;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_TestedAssetType_String_T_Boolean_HashSet_1_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_TestContext_1_Object_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Cast_Public_TestContext_1_Y_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 765983, RefRangeEnd = 765984, XrefRangeStart = 765980, XrefRangeEnd = 765983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TestContext(
      int testSessionId,
      TestedAssetType type,
      string assetPath,
      T assetObject,
      bool isAbstractAsset,
      HashSet<string> labels)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TestContext<T>>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &testSessionId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(assetPath);
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) assetObject;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref assetObject;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &isAbstractAsset;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) labels);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TestContext<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_TestedAssetType_String_T_Boolean_HashSet_1_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765984, XrefRangeEnd = 765988, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TestContext(TestContext<UnityEngine.Object> copySettingsFrom, T preCastAssetObject)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TestContext<T>>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) copySettingsFrom));
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) preCastAssetObject;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref preCastAssetObject;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TestContext<T>.NativeMethodInfoPtr__ctor_Public_Void_TestContext_1_Object_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765988, XrefRangeEnd = 765992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TestContext<Y> Cast<Y>() where Y : T
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(TestContext<Y>.MethodInfoStoreGeneric_Cast_Public_TestContext_1_Y_0\u00601.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new TestContext<Y>(pointer);
    }

    static TestContext()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<TestContext<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.ContentTesting", "TestContext`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TestContext<T>>.NativeClassPtr);
      TestContext<T>.NativeFieldInfoPtr_TestSessionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestContext<T>>.NativeClassPtr, nameof (TestSessionId));
      TestContext<T>.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestContext<T>>.NativeClassPtr, nameof (Type));
      TestContext<T>.NativeFieldInfoPtr_AssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestContext<T>>.NativeClassPtr, nameof (AssetPath));
      TestContext<T>.NativeFieldInfoPtr_RootAssetObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestContext<T>>.NativeClassPtr, nameof (RootAssetObject));
      TestContext<T>.NativeFieldInfoPtr_IsAbstractAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestContext<T>>.NativeClassPtr, nameof (IsAbstractAsset));
      TestContext<T>.NativeFieldInfoPtr_Labels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestContext<T>>.NativeClassPtr, nameof (Labels));
      TestContext<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_TestedAssetType_String_T_Boolean_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestContext<T>>.NativeClassPtr, 100667701);
      TestContext<T>.NativeMethodInfoPtr__ctor_Public_Void_TestContext_1_Object_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestContext<T>>.NativeClassPtr, 100667702);
      TestContext<T>.NativeMethodInfoPtr_Cast_Public_TestContext_1_Y_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestContext<T>>.NativeClassPtr, 100667703);
    }

    public TestContext(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public TestContext()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TestContext<T>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TestContext<T>>.NativeClassPtr, data));
    }

    public unsafe int TestSessionId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TestContext<T>.NativeFieldInfoPtr_TestSessionId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TestContext<T>.NativeFieldInfoPtr_TestSessionId)) = value;
      }
    }

    public unsafe TestedAssetType Type
    {
      get
      {
        return *(TestedAssetType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TestContext<T>.NativeFieldInfoPtr_Type));
      }
      [param: In] set
      {
        *(TestedAssetType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TestContext<T>.NativeFieldInfoPtr_Type)) = value;
      }
    }

    public unsafe string AssetPath
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TestContext<T>.NativeFieldInfoPtr_AssetPath)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TestContext<T>.NativeFieldInfoPtr_AssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe T RootAssetObject
    {
      get
      {
        return IL2CPP.PointerToValueGeneric<T>(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TestContext<T>.NativeFieldInfoPtr_RootAssetObject), true, false);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr targetAddress = ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TestContext<T>.NativeFieldInfoPtr_RootAssetObject);
        System.Type type = typeof (T);
        if (!type.IsValueType)
        {
          if (!string.Equals(type.FullName, "System.String"))
          {
            System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((object) value as Il2CppObjectBase);
            if (ptr != System.IntPtr.Zero && IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)))
            {
              System.IntPtr num1 = ptr;
              System.IntPtr num2 = IL2CPP.il2cpp_object_unbox(ptr);
              int num3 = IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(num1), (uint&) System.IntPtr.Zero);
              __memcpy(targetAddress, num2, num3);
            }
            else
              IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, targetAddress, ptr);
          }
          else
          {
            System.IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp((object) value as string);
            IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, targetAddress, il2Cpp);
          }
        }
        else
        {
          T obj = value;
          *(T*) targetAddress = obj;
        }
      }
    }

    public unsafe bool IsAbstractAsset
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TestContext<T>.NativeFieldInfoPtr_IsAbstractAsset));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TestContext<T>.NativeFieldInfoPtr_IsAbstractAsset)) = value;
      }
    }

    public unsafe HashSet<string> Labels
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TestContext<T>.NativeFieldInfoPtr_Labels));
        return pointer == System.IntPtr.Zero ? (HashSet<string>) null : new HashSet<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TestContext<T>.NativeFieldInfoPtr_Labels), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    private sealed class MethodInfoStoreGeneric_Cast_Public_TestContext_1_Y_0\u00601
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(TestContext<Y>.NativeMethodInfoPtr_Cast_Public_TestContext_1_Y_0, Il2CppClassPointerStore<TestContext<Y>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Y>.NativeClassPtr))
      }))));
    }
  }
}

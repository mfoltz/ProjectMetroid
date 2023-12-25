// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.NativeListExtension
// Assembly: ProjectM.CastleBuilding.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA7B9521-B45B-4FC8-A2B0-77040A5D8FB7
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CastleBuilding.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using Unity.Collections;

#nullable disable
namespace ProjectM.CastleBuilding
{
  public static class NativeListExtension : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_AddIfNotExist_Public_Static_Boolean_NativeList_1_T_T_0;

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 1200326, RefRangeEnd = 1200336, XrefRangeStart = 1200325, XrefRangeEnd = 1200326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool AddIfNotExist<T>(this NativeList<T> list, T value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &list;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) value;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref value;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NativeListExtension.MethodInfoStoreGeneric_AddIfNotExist_Public_Static_Boolean_NativeList_1_T_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    static NativeListExtension()
    {
      Il2CppClassPointerStore<NativeListExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CastleBuilding.Systems.dll", "ProjectM.CastleBuilding", nameof (NativeListExtension));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeListExtension>.NativeClassPtr);
      NativeListExtension.NativeMethodInfoPtr_AddIfNotExist_Public_Static_Boolean_NativeList_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeListExtension>.NativeClassPtr, 100664326);
    }

    public NativeListExtension(System.IntPtr pointer)
      : base(pointer)
    {
    }

    private sealed class MethodInfoStoreGeneric_AddIfNotExist_Public_Static_Boolean_NativeList_1_T_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeListExtension.NativeMethodInfoPtr_AddIfNotExist_Public_Static_Boolean_NativeList_1_T_T_0, Il2CppClassPointerStore<NativeListExtension>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}

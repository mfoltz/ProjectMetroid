// Decompiled with JetBrains decompiler
// Type: ProjectM.EnumerableExtensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

#nullable disable
namespace ProjectM
{
  public static class EnumerableExtensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_IEnumerable_1_T_0;

    [CallerCount(20)]
    [CachedScanResults(RefRangeStart = 764773, RefRangeEnd = 764793, XrefRangeStart = 764773, XrefRangeEnd = 764773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsNullOrEmpty<T>(this IEnumerable<T> source)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EnumerableExtensions.MethodInfoStoreGeneric_IsNullOrEmpty_Public_Static_Boolean_IEnumerable_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static EnumerableExtensions()
    {
      Il2CppClassPointerStore<EnumerableExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (EnumerableExtensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumerableExtensions>.NativeClassPtr);
      EnumerableExtensions.NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableExtensions>.NativeClassPtr, 100667543);
    }

    public EnumerableExtensions(System.IntPtr pointer)
      : base(pointer)
    {
    }

    private sealed class MethodInfoStoreGeneric_IsNullOrEmpty_Public_Static_Boolean_IEnumerable_1_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(EnumerableExtensions.NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_IEnumerable_1_T_0, Il2CppClassPointerStore<EnumerableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}

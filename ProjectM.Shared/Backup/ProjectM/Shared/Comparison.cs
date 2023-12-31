// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.Comparison
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

#nullable disable
namespace ProjectM.Shared
{
  public static class Comparison : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_Comparison_Unboxed_1_TValue_ConditionTypes_TValue_0;

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 258314, RefRangeEnd = 258319, XrefRangeStart = 258314, XrefRangeEnd = 258319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Comparison_Unboxed<TValue> Create<TValue>(
      ConditionTypes type,
      TValue value)
      where TValue : unmanaged
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &type;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TValue& local1;
      if (!typeof (TValue).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TValue> local2 = (System.ValueType) value;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TValue&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TValue&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref value;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Comparison.MethodInfoStoreGeneric_Create_Public_Static_Comparison_Unboxed_1_TValue_ConditionTypes_TValue_0<TValue>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Comparison_Unboxed<TValue>*) IL2CPP.il2cpp_object_unbox(num2);
    }

    static Comparison()
    {
      Il2CppClassPointerStore<Comparison>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (Comparison));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Comparison>.NativeClassPtr);
      Comparison.NativeMethodInfoPtr_Create_Public_Static_Comparison_Unboxed_1_TValue_ConditionTypes_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Comparison>.NativeClassPtr, 100670733);
    }

    public Comparison(System.IntPtr pointer)
      : base(pointer)
    {
    }

    private sealed class MethodInfoStoreGeneric_Create_Public_Static_Comparison_Unboxed_1_TValue_ConditionTypes_TValue_0<TValue>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Comparison.NativeMethodInfoPtr_Create_Public_Static_Comparison_Unboxed_1_TValue_ConditionTypes_TValue_0, Il2CppClassPointerStore<Comparison>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
      }))));
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.OptionalSharedField`1
// Assembly: ProjectM.CodeGeneration, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE751F2E-D812-4D5F-A9DE-9160851E105B
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CodeGeneration.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

#nullable disable
namespace ProjectM.Behaviours
{
  public struct OptionalSharedField<T>
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_HasValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlackboardIndex;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_0;
    public bool HasValue;
    public int BlackboardIndex;

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 633602, RefRangeEnd = 633614, XrefRangeStart = 633602, XrefRangeEnd = 633602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OptionalSharedField(bool hasValue, int blackboardIndex = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &hasValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &blackboardIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionalSharedField<T>.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static OptionalSharedField()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<OptionalSharedField<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.CodeGeneration.dll", "ProjectM.Behaviours", "OptionalSharedField`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionalSharedField<T>>.NativeClassPtr);
      OptionalSharedField<T>.NativeFieldInfoPtr_HasValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionalSharedField<T>>.NativeClassPtr, nameof (HasValue));
      OptionalSharedField<T>.NativeFieldInfoPtr_BlackboardIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionalSharedField<T>>.NativeClassPtr, nameof (BlackboardIndex));
      OptionalSharedField<T>.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalSharedField<T>>.NativeClassPtr, 100663327);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OptionalSharedField<T>>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

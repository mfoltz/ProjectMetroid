// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.SharedField`1
// Assembly: ProjectM.CodeGeneration, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE751F2E-D812-4D5F-A9DE-9160851E105B
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CodeGeneration.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

#nullable disable
namespace ProjectM.Behaviours
{
  public struct SharedField<T>
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BlackboardIndex;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToOptional_Public_OptionalSharedField_1_T_0;
    public int BlackboardIndex;

    [CallerCount(20)]
    [CachedScanResults(RefRangeStart = 45001, RefRangeEnd = 45021, XrefRangeStart = 45001, XrefRangeEnd = 45021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SharedField(int blackboardIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &blackboardIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SharedField<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 633600, XrefRangeEnd = 633602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OptionalSharedField<T> ToOptional()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SharedField<T>.NativeMethodInfoPtr_ToOptional_Public_OptionalSharedField_1_T_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(OptionalSharedField<T>*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SharedField()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<SharedField<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.CodeGeneration.dll", "ProjectM.Behaviours", "SharedField`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedField<T>>.NativeClassPtr);
      SharedField<T>.NativeFieldInfoPtr_BlackboardIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedField<T>>.NativeClassPtr, nameof (BlackboardIndex));
      SharedField<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedField<T>>.NativeClassPtr, 100663325);
      SharedField<T>.NativeMethodInfoPtr_ToOptional_Public_OptionalSharedField_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedField<T>>.NativeClassPtr, 100663326);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SharedField<T>>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

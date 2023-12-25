// Decompiled with JetBrains decompiler
// Type: ProjectM.CodeGeneration.Code
// Assembly: ProjectM.CodeGeneration, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE751F2E-D812-4D5F-A9DE-9160851E105B
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CodeGeneration.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

#nullable disable
namespace ProjectM.CodeGeneration
{
  public static class Code : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Field_Public_Static_String_Type_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Field_Public_Static_String_String_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Field_Public_Static_String_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Field_Public_Static_String_Accessor_Type_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Field_Public_Static_String_Accessor_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Field_Public_Static_String_Accessor_String_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAccessorText_Private_Static_String_Accessor_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 633679, XrefRangeEnd = 633687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string Field(Il2CppSystem.Type fieldType, string fieldName, string defaultValue = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fieldType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(fieldName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Code.NativeMethodInfoPtr_Field_Public_Static_String_Type_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 633687, XrefRangeEnd = 633688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string Field(string fieldType, string fieldName, string defaultValue = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(fieldType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(fieldName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Code.NativeMethodInfoPtr_Field_Public_Static_String_String_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 633688, XrefRangeEnd = 633693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string Field<TFieldType>(string fieldName, string defaultValue = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(fieldName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Code.MethodInfoStoreGeneric_Field_Public_Static_String_String_String_0<TFieldType>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 633702, RefRangeEnd = 633704, XrefRangeStart = 633693, XrefRangeEnd = 633702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string Field(
      Accessor accessor,
      Il2CppSystem.Type fieldType,
      string fieldName,
      string defaultValue = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &accessor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fieldType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(fieldName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Code.NativeMethodInfoPtr_Field_Public_Static_String_Accessor_Type_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 633704, XrefRangeEnd = 633709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string Field<TFieldType>(
      Accessor accessor,
      string fieldName,
      string defaultValue = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &accessor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(fieldName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Code.MethodInfoStoreGeneric_Field_Public_Static_String_Accessor_String_String_0<TFieldType>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 633801, RefRangeEnd = 633805, XrefRangeStart = 633709, XrefRangeEnd = 633801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string Field(
      Accessor accessor,
      string fieldType,
      string fieldName,
      string defaultValue = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &accessor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(fieldType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(fieldName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Code.NativeMethodInfoPtr_Field_Public_Static_String_Accessor_String_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 633856, RefRangeEnd = 633857, XrefRangeStart = 633805, XrefRangeEnd = 633856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetAccessorText(Accessor accessor)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &accessor;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Code.NativeMethodInfoPtr_GetAccessorText_Private_Static_String_Accessor_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static Code()
    {
      Il2CppClassPointerStore<Code>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CodeGeneration.dll", "ProjectM.CodeGeneration", nameof (Code));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Code>.NativeClassPtr);
      Code.NativeMethodInfoPtr_Field_Public_Static_String_Type_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Code>.NativeClassPtr, 100663344);
      Code.NativeMethodInfoPtr_Field_Public_Static_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Code>.NativeClassPtr, 100663345);
      Code.NativeMethodInfoPtr_Field_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Code>.NativeClassPtr, 100663346);
      Code.NativeMethodInfoPtr_Field_Public_Static_String_Accessor_Type_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Code>.NativeClassPtr, 100663347);
      Code.NativeMethodInfoPtr_Field_Public_Static_String_Accessor_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Code>.NativeClassPtr, 100663348);
      Code.NativeMethodInfoPtr_Field_Public_Static_String_Accessor_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Code>.NativeClassPtr, 100663349);
      Code.NativeMethodInfoPtr_GetAccessorText_Private_Static_String_Accessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Code>.NativeClassPtr, 100663350);
    }

    public Code(System.IntPtr pointer)
      : base(pointer)
    {
    }

    private sealed class MethodInfoStoreGeneric_Field_Public_Static_String_String_String_0<TFieldType>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Code.NativeMethodInfoPtr_Field_Public_Static_String_String_String_0, Il2CppClassPointerStore<Code>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFieldType>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Field_Public_Static_String_Accessor_String_String_0<TFieldType>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Code.NativeMethodInfoPtr_Field_Public_Static_String_Accessor_String_String_0, Il2CppClassPointerStore<Code>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFieldType>.NativeClassPtr))
      }))));
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: ProjectM.CompatibilityCLI
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Compatibility;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class CompatibilityCLI : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckIfCheckCompatibility_Public_Static_Void_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckVersionCompatibility_Public_Static_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckVersionCompatibility_Public_Static_Boolean_PersistenceCompatibilityData_PersistenceCompatibilityData_byref_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckIfGenerateCompatibility_Public_Static_Void_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenerateVersionCompatibility_Public_Static_Void_String_ApplicationType_PrefabConversionMethod_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateServerWorld_Public_Static_World_GameBootstrap_Boolean_Boolean_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 987688, RefRangeEnd = 987690, XrefRangeStart = 987671, XrefRangeEnd = 987688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CheckIfCheckCompatibility(out bool exitApplication)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref exitApplication;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CompatibilityCLI.NativeMethodInfoPtr_CheckIfCheckCompatibility_Public_Static_Void_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 987730, RefRangeEnd = 987731, XrefRangeStart = 987690, XrefRangeEnd = 987730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CheckVersionCompatibility(string targetValidationPath)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(targetValidationPath);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CompatibilityCLI.NativeMethodInfoPtr_CheckVersionCompatibility_Public_Static_Void_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 987771, RefRangeEnd = 987772, XrefRangeStart = 987731, XrefRangeEnd = 987771, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CheckVersionCompatibility(
      PersistenceCompatibilityData localValidation,
      PersistenceCompatibilityData targetValidation,
      out string resultStr)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) localValidation);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetValidation);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CompatibilityCLI.NativeMethodInfoPtr_CheckVersionCompatibility_Public_Static_Boolean_PersistenceCompatibilityData_PersistenceCompatibilityData_byref_String_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      resultStr = IL2CPP.Il2CppStringToManaged(zero);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 987810, RefRangeEnd = 987811, XrefRangeStart = 987772, XrefRangeEnd = 987810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CheckIfGenerateCompatibility(out bool exitApplication)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref exitApplication;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CompatibilityCLI.NativeMethodInfoPtr_CheckIfGenerateCompatibility_Public_Static_Void_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 987892, RefRangeEnd = 987893, XrefRangeStart = 987811, XrefRangeEnd = 987892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GenerateVersionCompatibility(
      string outputFolderPath,
      ApplicationType applicationType,
      PrefabConversionMethod conversionMethod)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(outputFolderPath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &applicationType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &conversionMethod;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CompatibilityCLI.NativeMethodInfoPtr_GenerateVersionCompatibility_Public_Static_Void_String_ApplicationType_PrefabConversionMethod_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 988003, RefRangeEnd = 988004, XrefRangeStart = 987893, XrefRangeEnd = 988003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe World CreateServerWorld(
      GameBootstrap gameBootstrap,
      bool forceUseSubScenes,
      bool keepLoadedDataAfterLoad)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameBootstrap);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &forceUseSubScenes;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &keepLoadedDataAfterLoad;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CompatibilityCLI.NativeMethodInfoPtr_CreateServerWorld_Public_Static_World_GameBootstrap_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (World) null : new World(pointer);
    }

    static CompatibilityCLI()
    {
      Il2CppClassPointerStore<CompatibilityCLI>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CompatibilityCLI));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompatibilityCLI>.NativeClassPtr);
      CompatibilityCLI.NativeMethodInfoPtr_CheckIfCheckCompatibility_Public_Static_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibilityCLI>.NativeClassPtr, 100676183);
      CompatibilityCLI.NativeMethodInfoPtr_CheckVersionCompatibility_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibilityCLI>.NativeClassPtr, 100676184);
      CompatibilityCLI.NativeMethodInfoPtr_CheckVersionCompatibility_Public_Static_Boolean_PersistenceCompatibilityData_PersistenceCompatibilityData_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibilityCLI>.NativeClassPtr, 100676185);
      CompatibilityCLI.NativeMethodInfoPtr_CheckIfGenerateCompatibility_Public_Static_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibilityCLI>.NativeClassPtr, 100676186);
      CompatibilityCLI.NativeMethodInfoPtr_GenerateVersionCompatibility_Public_Static_Void_String_ApplicationType_PrefabConversionMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibilityCLI>.NativeClassPtr, 100676187);
      CompatibilityCLI.NativeMethodInfoPtr_CreateServerWorld_Public_Static_World_GameBootstrap_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibilityCLI>.NativeClassPtr, 100676188);
    }

    public CompatibilityCLI(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}

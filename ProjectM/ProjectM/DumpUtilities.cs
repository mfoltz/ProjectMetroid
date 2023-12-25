// Decompiled with JetBrains decompiler
// Type: ProjectM.DumpUtilities
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
namespace ProjectM
{
  public static class DumpUtilities : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDumpFolderPath_Public_Static_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOrSetupDumpRootPath_Public_Static_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFreeDumpFileTxtPath_Public_Static_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFreeDumpFileCsvPath_Public_Static_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFreeDumpFilePathWithExtension_Private_Static_String_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OpenDumpFolder_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993756, XrefRangeEnd = 993763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetDumpFolderPath()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(DumpUtilities.NativeMethodInfoPtr_GetDumpFolderPath_Public_Static_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993763, XrefRangeEnd = 993772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetOrSetupDumpRootPath()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(DumpUtilities.NativeMethodInfoPtr_GetOrSetupDumpRootPath_Public_Static_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 993775, RefRangeEnd = 993778, XrefRangeStart = 993772, XrefRangeEnd = 993775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetFreeDumpFileTxtPath(string name)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(DumpUtilities.NativeMethodInfoPtr_GetFreeDumpFileTxtPath_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 993781, RefRangeEnd = 993782, XrefRangeStart = 993778, XrefRangeEnd = 993781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetFreeDumpFileCsvPath(string name)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(DumpUtilities.NativeMethodInfoPtr_GetFreeDumpFileCsvPath_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 993819, RefRangeEnd = 993821, XrefRangeStart = 993782, XrefRangeEnd = 993819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetFreeDumpFilePathWithExtension(string name, string extension)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(extension);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(DumpUtilities.NativeMethodInfoPtr_GetFreeDumpFilePathWithExtension_Private_Static_String_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 993829, RefRangeEnd = 993832, XrefRangeStart = 993821, XrefRangeEnd = 993829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OpenDumpFolder()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DumpUtilities.NativeMethodInfoPtr_OpenDumpFolder_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DumpUtilities()
    {
      Il2CppClassPointerStore<DumpUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DumpUtilities));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DumpUtilities>.NativeClassPtr);
      DumpUtilities.NativeMethodInfoPtr_GetDumpFolderPath_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DumpUtilities>.NativeClassPtr, 100676733);
      DumpUtilities.NativeMethodInfoPtr_GetOrSetupDumpRootPath_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DumpUtilities>.NativeClassPtr, 100676734);
      DumpUtilities.NativeMethodInfoPtr_GetFreeDumpFileTxtPath_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DumpUtilities>.NativeClassPtr, 100676735);
      DumpUtilities.NativeMethodInfoPtr_GetFreeDumpFileCsvPath_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DumpUtilities>.NativeClassPtr, 100676736);
      DumpUtilities.NativeMethodInfoPtr_GetFreeDumpFilePathWithExtension_Private_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DumpUtilities>.NativeClassPtr, 100676737);
      DumpUtilities.NativeMethodInfoPtr_OpenDumpFolder_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DumpUtilities>.NativeClassPtr, 100676738);
    }

    public DumpUtilities(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}

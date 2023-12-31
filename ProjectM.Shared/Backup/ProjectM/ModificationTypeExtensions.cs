// Decompiled with JetBrains decompiler
// Type: ProjectM.ModificationTypeExtensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
namespace ProjectM
{
  public static class ModificationTypeExtensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ToModificationTypeDOTS_Public_Static_ModificationType_ModificationType_Editor_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 746883, RefRangeEnd = 746886, XrefRangeStart = 746883, XrefRangeEnd = 746883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ModificationType ToModificationTypeDOTS(
      this ModificationType_Editor modificationTypeEditor)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &modificationTypeEditor;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModificationTypeExtensions.NativeMethodInfoPtr_ToModificationTypeDOTS_Public_Static_ModificationType_ModificationType_Editor_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationType*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ModificationTypeExtensions()
    {
      Il2CppClassPointerStore<ModificationTypeExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ModificationTypeExtensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModificationTypeExtensions>.NativeClassPtr);
      ModificationTypeExtensions.NativeMethodInfoPtr_ToModificationTypeDOTS_Public_Static_ModificationType_ModificationType_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModificationTypeExtensions>.NativeClassPtr, 100665726);
    }

    public ModificationTypeExtensions(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}

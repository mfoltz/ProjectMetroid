// Decompiled with JetBrains decompiler
// Type: ProjectM.Compatibility.PersistenceCompatibilityResult
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Compatibility
{
  public class PersistenceCompatibilityResult : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Issues;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsCompatible_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CompatibilityIssue_Public_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe bool IsCompatible
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 1111768, RefRangeEnd = 1111769, XrefRangeStart = 1111767, XrefRangeEnd = 1111768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityResult.NativeMethodInfoPtr_get_IsCompatible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111769, XrefRangeEnd = 1111773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CompatibilityIssue(string issue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(issue);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityResult.NativeMethodInfoPtr_CompatibilityIssue_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111773, XrefRangeEnd = 1111781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PersistenceCompatibilityResult()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersistenceCompatibilityResult>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityResult.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PersistenceCompatibilityResult()
    {
      Il2CppClassPointerStore<PersistenceCompatibilityResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Compatibility", nameof (PersistenceCompatibilityResult));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistenceCompatibilityResult>.NativeClassPtr);
      PersistenceCompatibilityResult.NativeFieldInfoPtr_Issues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityResult>.NativeClassPtr, nameof (Issues));
      PersistenceCompatibilityResult.NativeMethodInfoPtr_get_IsCompatible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityResult>.NativeClassPtr, 100687986);
      PersistenceCompatibilityResult.NativeMethodInfoPtr_CompatibilityIssue_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityResult>.NativeClassPtr, 100687987);
      PersistenceCompatibilityResult.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityResult>.NativeClassPtr, 100687988);
    }

    public PersistenceCompatibilityResult(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<string> Issues
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityResult.NativeFieldInfoPtr_Issues));
        return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityResult.NativeFieldInfoPtr_Issues), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}

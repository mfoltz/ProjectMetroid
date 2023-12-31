// Decompiled with JetBrains decompiler
// Type: ProjectM.ContentTesting.PrefabContentTestAttribute
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.ContentTesting
{
  public class PrefabContentTestAttribute : Il2CppSystem.Attribute
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TestName;
    private static readonly System.IntPtr NativeFieldInfoPtr_TestGroupFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_RunForAbstractPrefabs;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsHeavyTest;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_TestGroupFlags_Boolean_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765860, XrefRangeEnd = 765862, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PrefabContentTestAttribute(
      string testName,
      TestGroupFlags testGroupFlags,
      bool runForAbstractPrefabs)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabContentTestAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(testName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &testGroupFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &runForAbstractPrefabs;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrefabContentTestAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_TestGroupFlags_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PrefabContentTestAttribute()
    {
      Il2CppClassPointerStore<PrefabContentTestAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.ContentTesting", nameof (PrefabContentTestAttribute));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabContentTestAttribute>.NativeClassPtr);
      PrefabContentTestAttribute.NativeFieldInfoPtr_TestName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabContentTestAttribute>.NativeClassPtr, nameof (TestName));
      PrefabContentTestAttribute.NativeFieldInfoPtr_TestGroupFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabContentTestAttribute>.NativeClassPtr, nameof (TestGroupFlags));
      PrefabContentTestAttribute.NativeFieldInfoPtr_RunForAbstractPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabContentTestAttribute>.NativeClassPtr, nameof (RunForAbstractPrefabs));
      PrefabContentTestAttribute.NativeFieldInfoPtr_IsHeavyTest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabContentTestAttribute>.NativeClassPtr, nameof (IsHeavyTest));
      PrefabContentTestAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_TestGroupFlags_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabContentTestAttribute>.NativeClassPtr, 100667677);
    }

    public PrefabContentTestAttribute(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string TestName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabContentTestAttribute.NativeFieldInfoPtr_TestName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrefabContentTestAttribute.NativeFieldInfoPtr_TestName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe TestGroupFlags TestGroupFlags
    {
      get
      {
        return *(TestGroupFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabContentTestAttribute.NativeFieldInfoPtr_TestGroupFlags));
      }
      [param: In] set
      {
        *(TestGroupFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabContentTestAttribute.NativeFieldInfoPtr_TestGroupFlags)) = value;
      }
    }

    public unsafe bool RunForAbstractPrefabs
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabContentTestAttribute.NativeFieldInfoPtr_RunForAbstractPrefabs));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabContentTestAttribute.NativeFieldInfoPtr_RunForAbstractPrefabs)) = value;
      }
    }

    public unsafe bool IsHeavyTest
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabContentTestAttribute.NativeFieldInfoPtr_IsHeavyTest));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabContentTestAttribute.NativeFieldInfoPtr_IsHeavyTest)) = value;
      }
    }
  }
}

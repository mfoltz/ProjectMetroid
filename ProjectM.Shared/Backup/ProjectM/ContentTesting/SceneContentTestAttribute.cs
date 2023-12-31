// Decompiled with JetBrains decompiler
// Type: ProjectM.ContentTesting.SceneContentTestAttribute
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
  public class SceneContentTestAttribute : Il2CppSystem.Attribute
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TestName;
    private static readonly System.IntPtr NativeFieldInfoPtr_TestGroupFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsHeavyTest;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_TestGroupFlags_0;

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 168620, RefRangeEnd = 168627, XrefRangeStart = 168620, XrefRangeEnd = 168627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SceneContentTestAttribute(string testName, TestGroupFlags testGroupFlags)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneContentTestAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(testName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &testGroupFlags;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SceneContentTestAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_TestGroupFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SceneContentTestAttribute()
    {
      Il2CppClassPointerStore<SceneContentTestAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.ContentTesting", nameof (SceneContentTestAttribute));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneContentTestAttribute>.NativeClassPtr);
      SceneContentTestAttribute.NativeFieldInfoPtr_TestName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneContentTestAttribute>.NativeClassPtr, nameof (TestName));
      SceneContentTestAttribute.NativeFieldInfoPtr_TestGroupFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneContentTestAttribute>.NativeClassPtr, nameof (TestGroupFlags));
      SceneContentTestAttribute.NativeFieldInfoPtr_IsHeavyTest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneContentTestAttribute>.NativeClassPtr, nameof (IsHeavyTest));
      SceneContentTestAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_TestGroupFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneContentTestAttribute>.NativeClassPtr, 100667679);
    }

    public SceneContentTestAttribute(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string TestName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneContentTestAttribute.NativeFieldInfoPtr_TestName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneContentTestAttribute.NativeFieldInfoPtr_TestName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe TestGroupFlags TestGroupFlags
    {
      get
      {
        return *(TestGroupFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneContentTestAttribute.NativeFieldInfoPtr_TestGroupFlags));
      }
      [param: In] set
      {
        *(TestGroupFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneContentTestAttribute.NativeFieldInfoPtr_TestGroupFlags)) = value;
      }
    }

    public unsafe bool IsHeavyTest
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneContentTestAttribute.NativeFieldInfoPtr_IsHeavyTest));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneContentTestAttribute.NativeFieldInfoPtr_IsHeavyTest)) = value;
      }
    }
  }
}

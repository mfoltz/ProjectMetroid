// Decompiled with JetBrains decompiler
// Type: ProjectM.ContentTesting.ContentHotfix
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
  public class ContentHotfix : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Title;
    private static readonly System.IntPtr NativeFieldInfoPtr_RunAction;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ContentHotfix()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContentHotfix>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ContentHotfix.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ContentHotfix()
    {
      Il2CppClassPointerStore<ContentHotfix>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.ContentTesting", nameof (ContentHotfix));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContentHotfix>.NativeClassPtr);
      ContentHotfix.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentHotfix>.NativeClassPtr, nameof (Title));
      ContentHotfix.NativeFieldInfoPtr_RunAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentHotfix>.NativeClassPtr, nameof (RunAction));
      ContentHotfix.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentHotfix>.NativeClassPtr, 100667700);
    }

    public ContentHotfix(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string Title
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContentHotfix.NativeFieldInfoPtr_Title)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ContentHotfix.NativeFieldInfoPtr_Title), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Il2CppSystem.Action RunAction
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContentHotfix.NativeFieldInfoPtr_RunAction));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ContentHotfix.NativeFieldInfoPtr_RunAction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}

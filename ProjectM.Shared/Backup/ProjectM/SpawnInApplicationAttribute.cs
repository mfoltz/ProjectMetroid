// Decompiled with JetBrains decompiler
// Type: ProjectM.SpawnInApplicationAttribute
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class SpawnInApplicationAttribute : Il2CppSystem.Attribute
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Application;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_ApplicationType_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720843, XrefRangeEnd = 720845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpawnInApplicationAttribute([Optional] Il2CppStructArray<ApplicationType> applications)
    {
      if (applications == null)
        applications = new Il2CppStructArray<ApplicationType>(0L);
      // ISSUE: explicit constructor call
      this.\u002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnInApplicationAttribute>.NativeClassPtr));
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) applications);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnInApplicationAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_ApplicationType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public SpawnInApplicationAttribute(params ApplicationType[] applications)
      : this(new Il2CppStructArray<ApplicationType>(applications))
    {
    }

    static SpawnInApplicationAttribute()
    {
      Il2CppClassPointerStore<SpawnInApplicationAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SpawnInApplicationAttribute));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnInApplicationAttribute>.NativeClassPtr);
      SpawnInApplicationAttribute.NativeFieldInfoPtr_Application = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnInApplicationAttribute>.NativeClassPtr, nameof (Application));
      SpawnInApplicationAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_ApplicationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnInApplicationAttribute>.NativeClassPtr, 100663703);
    }

    public SpawnInApplicationAttribute(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ApplicationType Application
    {
      get
      {
        return *(ApplicationType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnInApplicationAttribute.NativeFieldInfoPtr_Application));
      }
      [param: In] set
      {
        *(ApplicationType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnInApplicationAttribute.NativeFieldInfoPtr_Application)) = value;
      }
    }
  }
}

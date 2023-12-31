// Decompiled with JetBrains decompiler
// Type: ProjectM.SpawnInWorldAttribute
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class SpawnInWorldAttribute : Il2CppSystem.Attribute
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_World;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_WorldType_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpawnInWorldAttribute([Optional] Il2CppStructArray<WorldType> worlds)
    {
      if (worlds == null)
        worlds = new Il2CppStructArray<WorldType>(0L);
      // ISSUE: explicit constructor call
      this.\u002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnInWorldAttribute>.NativeClassPtr));
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) worlds);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnInWorldAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_WorldType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public SpawnInWorldAttribute(params WorldType[] worlds)
      : this(new Il2CppStructArray<WorldType>(worlds))
    {
    }

    static SpawnInWorldAttribute()
    {
      Il2CppClassPointerStore<SpawnInWorldAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SpawnInWorldAttribute));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnInWorldAttribute>.NativeClassPtr);
      SpawnInWorldAttribute.NativeFieldInfoPtr_World = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnInWorldAttribute>.NativeClassPtr, nameof (World));
      SpawnInWorldAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_WorldType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnInWorldAttribute>.NativeClassPtr, 100663704);
    }

    public SpawnInWorldAttribute(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe WorldType World
    {
      get
      {
        return *(WorldType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnInWorldAttribute.NativeFieldInfoPtr_World));
      }
      [param: In] set
      {
        *(WorldType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnInWorldAttribute.NativeFieldInfoPtr_World)) = value;
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: ProjectM.CritterSpawn
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class CritterSpawn : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CritterGUIDs;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnAreaWidth;
    private static readonly System.IntPtr NativeFieldInfoPtr_OffsetStrength;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988091, XrefRangeEnd = 988099, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.Object System_ICloneable_Clone()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CritterSpawn.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CritterSpawn()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterSpawn.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CritterSpawn()
    {
      Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CritterSpawn));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr);
      CritterSpawn.NativeFieldInfoPtr_CritterGUIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr, nameof (CritterGUIDs));
      CritterSpawn.NativeFieldInfoPtr_SpawnAreaWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr, nameof (SpawnAreaWidth));
      CritterSpawn.NativeFieldInfoPtr_OffsetStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr, nameof (OffsetStrength));
      CritterSpawn.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr, 100676201);
      CritterSpawn.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr, 100676202);
    }

    public CritterSpawn(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppStructArray<PrefabGUID> CritterGUIDs
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr_CritterGUIDs));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<PrefabGUID>) null : new Il2CppStructArray<PrefabGUID>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr_CritterGUIDs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float SpawnAreaWidth
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr_SpawnAreaWidth));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr_SpawnAreaWidth)) = value;
      }
    }

    public unsafe float OffsetStrength
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr_OffsetStrength));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr_OffsetStrength)) = value;
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: GameVersionData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
public class GameVersionData : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_HasData;
  private static readonly System.IntPtr NativeFieldInfoPtr_Name;
  private static readonly System.IntPtr NativeFieldInfoPtr_Major;
  private static readonly System.IntPtr NativeFieldInfoPtr_Minor;
  private static readonly System.IntPtr NativeFieldInfoPtr_Patch;
  private static readonly System.IntPtr NativeFieldInfoPtr_Revision;
  private static readonly System.IntPtr NativeFieldInfoPtr_PersistenceRevision;
  private static readonly System.IntPtr NativeFieldInfoPtr_Date;
  private static readonly System.IntPtr NativeFieldInfoPtr_VersionString;
  private static readonly System.IntPtr NativeFieldInfoPtr_SmallVersionString;
  private static readonly System.IntPtr NativeFieldInfoPtr_MidVersionString;
  private static readonly System.IntPtr NativeFieldInfoPtr_FullVersionString;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(3875)]
  [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GameVersionData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameVersionData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GameVersionData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static GameVersionData()
  {
    Il2CppClassPointerStore<GameVersionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (GameVersionData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameVersionData>.NativeClassPtr);
    GameVersionData.NativeFieldInfoPtr_HasData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersionData>.NativeClassPtr, nameof (HasData));
    GameVersionData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersionData>.NativeClassPtr, nameof (Name));
    GameVersionData.NativeFieldInfoPtr_Major = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersionData>.NativeClassPtr, nameof (Major));
    GameVersionData.NativeFieldInfoPtr_Minor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersionData>.NativeClassPtr, nameof (Minor));
    GameVersionData.NativeFieldInfoPtr_Patch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersionData>.NativeClassPtr, nameof (Patch));
    GameVersionData.NativeFieldInfoPtr_Revision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersionData>.NativeClassPtr, nameof (Revision));
    GameVersionData.NativeFieldInfoPtr_PersistenceRevision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersionData>.NativeClassPtr, nameof (PersistenceRevision));
    GameVersionData.NativeFieldInfoPtr_Date = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersionData>.NativeClassPtr, nameof (Date));
    GameVersionData.NativeFieldInfoPtr_VersionString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersionData>.NativeClassPtr, nameof (VersionString));
    GameVersionData.NativeFieldInfoPtr_SmallVersionString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersionData>.NativeClassPtr, nameof (SmallVersionString));
    GameVersionData.NativeFieldInfoPtr_MidVersionString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersionData>.NativeClassPtr, nameof (MidVersionString));
    GameVersionData.NativeFieldInfoPtr_FullVersionString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersionData>.NativeClassPtr, nameof (FullVersionString));
    GameVersionData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVersionData>.NativeClassPtr, 100663305);
  }

  public GameVersionData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool HasData
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameVersionData.NativeFieldInfoPtr_HasData));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameVersionData.NativeFieldInfoPtr_HasData)) = value;
    }
  }

  public unsafe string Name
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameVersionData.NativeFieldInfoPtr_Name)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameVersionData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int Major
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameVersionData.NativeFieldInfoPtr_Major));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameVersionData.NativeFieldInfoPtr_Major)) = value;
    }
  }

  public unsafe int Minor
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameVersionData.NativeFieldInfoPtr_Minor));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameVersionData.NativeFieldInfoPtr_Minor)) = value;
    }
  }

  public unsafe int Patch
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameVersionData.NativeFieldInfoPtr_Patch));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameVersionData.NativeFieldInfoPtr_Patch)) = value;
    }
  }

  public unsafe int Revision
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameVersionData.NativeFieldInfoPtr_Revision));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameVersionData.NativeFieldInfoPtr_Revision)) = value;
    }
  }

  public unsafe int PersistenceRevision
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameVersionData.NativeFieldInfoPtr_PersistenceRevision));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameVersionData.NativeFieldInfoPtr_PersistenceRevision)) = value;
    }
  }

  public unsafe string Date
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameVersionData.NativeFieldInfoPtr_Date)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameVersionData.NativeFieldInfoPtr_Date), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string VersionString
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameVersionData.NativeFieldInfoPtr_VersionString)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameVersionData.NativeFieldInfoPtr_VersionString), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string SmallVersionString
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameVersionData.NativeFieldInfoPtr_SmallVersionString)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameVersionData.NativeFieldInfoPtr_SmallVersionString), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string MidVersionString
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameVersionData.NativeFieldInfoPtr_MidVersionString)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameVersionData.NativeFieldInfoPtr_MidVersionString), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string FullVersionString
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameVersionData.NativeFieldInfoPtr_FullVersionString)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameVersionData.NativeFieldInfoPtr_FullVersionString), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}

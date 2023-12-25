// Decompiled with JetBrains decompiler
// Type: ProjectM.UserMapZoneElement
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Terrain;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UserMapZoneElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ZoneType;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsChunkInstance;
    private static readonly System.IntPtr NativeFieldInfoPtr_ZoneStartChunk;
    private static readonly System.IntPtr NativeFieldInfoPtr_UserZoneEntity;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsWorldZone_Public_Boolean_WorldZoneId_0;
    [FieldOffset(0)]
    public WorldZone ZoneType;
    [FieldOffset(4)]
    public bool IsChunkInstance;
    [FieldOffset(8)]
    public TerrainChunk ZoneStartChunk;
    [FieldOffset(16)]
    public NetworkedEntity UserZoneEntity;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1049419, RefRangeEnd = 1049420, XrefRangeStart = 1049418, XrefRangeEnd = 1049419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsWorldZone(WorldZoneId zoneId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &zoneId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserMapZoneElement.NativeMethodInfoPtr_IsWorldZone_Public_Boolean_WorldZoneId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static UserMapZoneElement()
    {
      Il2CppClassPointerStore<UserMapZoneElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (UserMapZoneElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserMapZoneElement>.NativeClassPtr);
      UserMapZoneElement.NativeFieldInfoPtr_ZoneType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserMapZoneElement>.NativeClassPtr, nameof (ZoneType));
      UserMapZoneElement.NativeFieldInfoPtr_IsChunkInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserMapZoneElement>.NativeClassPtr, nameof (IsChunkInstance));
      UserMapZoneElement.NativeFieldInfoPtr_ZoneStartChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserMapZoneElement>.NativeClassPtr, nameof (ZoneStartChunk));
      UserMapZoneElement.NativeFieldInfoPtr_UserZoneEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserMapZoneElement>.NativeClassPtr, nameof (UserZoneEntity));
      UserMapZoneElement.NativeMethodInfoPtr_IsWorldZone_Public_Boolean_WorldZoneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserMapZoneElement>.NativeClassPtr, 100682340);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UserMapZoneElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

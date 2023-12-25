// Decompiled with JetBrains decompiler
// Type: ProjectM.DynamicCollision
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DynamicCollision
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AgainstUnits;
    private static readonly System.IntPtr NativeFieldInfoPtr_AgainstPlayers;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkMultiplier;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_Immobile;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCollisionData_Public_DynamicCollisionSettings_Boolean_0;
    [FieldOffset(0)]
    public DynamicCollisionSettings AgainstUnits;
    [FieldOffset(32)]
    public DynamicCollisionSettings AgainstPlayers;
    [FieldOffset(64)]
    public float NetworkMultiplier;
    [FieldOffset(68)]
    public float2 NetworkDirection;
    [FieldOffset(76)]
    public bool Immobile;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1006791, RefRangeEnd = 1006794, XrefRangeStart = 1006791, XrefRangeEnd = 1006791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DynamicCollisionSettings GetCollisionData(bool isPlayer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &isPlayer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DynamicCollision.NativeMethodInfoPtr_GetCollisionData_Public_DynamicCollisionSettings_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DynamicCollisionSettings*) IL2CPP.il2cpp_object_unbox(num);
    }

    static DynamicCollision()
    {
      Il2CppClassPointerStore<DynamicCollision>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DynamicCollision));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicCollision>.NativeClassPtr);
      DynamicCollision.NativeFieldInfoPtr_AgainstUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicCollision>.NativeClassPtr, nameof (AgainstUnits));
      DynamicCollision.NativeFieldInfoPtr_AgainstPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicCollision>.NativeClassPtr, nameof (AgainstPlayers));
      DynamicCollision.NativeFieldInfoPtr_NetworkMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicCollision>.NativeClassPtr, nameof (NetworkMultiplier));
      DynamicCollision.NativeFieldInfoPtr_NetworkDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicCollision>.NativeClassPtr, nameof (NetworkDirection));
      DynamicCollision.NativeFieldInfoPtr_Immobile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicCollision>.NativeClassPtr, nameof (Immobile));
      DynamicCollision.NativeMethodInfoPtr_GetCollisionData_Public_DynamicCollisionSettings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicCollision>.NativeClassPtr, 100678142);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DynamicCollision>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

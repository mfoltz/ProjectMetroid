// Decompiled with JetBrains decompiler
// Type: ProjectM.AggroBuffer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AggroBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TaggedForRemovalTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_NextPlayerCombatBuffSpawnTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProximityValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExternalValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_Weight;
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsPlayer;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Value_Public_get_Single_0;
    [FieldOffset(0)]
    public double TaggedForRemovalTime;
    [FieldOffset(8)]
    public double NextPlayerCombatBuffSpawnTime;
    [FieldOffset(16)]
    public float ProximityValue;
    [FieldOffset(20)]
    public float DamageValue;
    [FieldOffset(24)]
    public float ExternalValue;
    [FieldOffset(28)]
    public float Weight;
    [FieldOffset(32)]
    public Entity Entity;
    [FieldOffset(40)]
    public bool IsPlayer;

    public unsafe float Value
    {
      [CallerCount(10), CachedScanResults(RefRangeStart = 723002, RefRangeEnd = 723012, XrefRangeStart = 723002, XrefRangeEnd = 723002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroBuffer.NativeMethodInfoPtr_get_Value_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static AggroBuffer()
    {
      Il2CppClassPointerStore<AggroBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AggroBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AggroBuffer>.NativeClassPtr);
      AggroBuffer.NativeFieldInfoPtr_TaggedForRemovalTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroBuffer>.NativeClassPtr, nameof (TaggedForRemovalTime));
      AggroBuffer.NativeFieldInfoPtr_NextPlayerCombatBuffSpawnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroBuffer>.NativeClassPtr, nameof (NextPlayerCombatBuffSpawnTime));
      AggroBuffer.NativeFieldInfoPtr_ProximityValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroBuffer>.NativeClassPtr, nameof (ProximityValue));
      AggroBuffer.NativeFieldInfoPtr_DamageValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroBuffer>.NativeClassPtr, nameof (DamageValue));
      AggroBuffer.NativeFieldInfoPtr_ExternalValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroBuffer>.NativeClassPtr, nameof (ExternalValue));
      AggroBuffer.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroBuffer>.NativeClassPtr, nameof (Weight));
      AggroBuffer.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroBuffer>.NativeClassPtr, nameof (Entity));
      AggroBuffer.NativeFieldInfoPtr_IsPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroBuffer>.NativeClassPtr, nameof (IsPlayer));
      AggroBuffer.NativeMethodInfoPtr_get_Value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroBuffer>.NativeClassPtr, 100663875);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AggroBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

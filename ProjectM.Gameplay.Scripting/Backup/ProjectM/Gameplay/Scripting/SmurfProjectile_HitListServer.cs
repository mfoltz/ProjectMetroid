// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.SmurfProjectile_HitListServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SmurfProjectile_HitListServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SmurfProjectile_HitListServer_0;
    [FieldOffset(0)]
    public Entity Entity;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189608, XrefRangeEnd = 1189609, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(SmurfProjectile_HitListServer other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SmurfProjectile_HitListServer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SmurfProjectile_HitListServer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SmurfProjectile_HitListServer()
    {
      Il2CppClassPointerStore<SmurfProjectile_HitListServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (SmurfProjectile_HitListServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmurfProjectile_HitListServer>.NativeClassPtr);
      SmurfProjectile_HitListServer.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmurfProjectile_HitListServer>.NativeClassPtr, nameof (Entity));
      SmurfProjectile_HitListServer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SmurfProjectile_HitListServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmurfProjectile_HitListServer>.NativeClassPtr, 100664855);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SmurfProjectile_HitListServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
